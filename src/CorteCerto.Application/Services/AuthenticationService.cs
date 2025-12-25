using CorteCerto.Domain.Base;
using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Domain.Interfaces.Services;
using CorteCerto.Domain.Responses;
using Microsoft.Extensions.Logging;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace CorteCerto.Application.Services;

public class AuthenticationService(
    IPersonRepository personRepository,
    IPasswordHashService passwordHashService,
    ITokenProvider tokenProvider,
    ILogger<AuthenticationService> logger)
    : IAuthenticationService
{
    private readonly JwtSecurityTokenHandler _tokenHandler = new();

    public Result<Token> Authenticate(Person person, string password)
    {
        var comparePasswordResult = passwordHashService.Verify(password, person.PasswordHash);

        if (!comparePasswordResult)
        {
            logger.LogInformation("Authentication failed because incorrect password for user with email: {Email}", person.Email);

            return Result<Token>.Failure(AuthenticationErrors.IncorrectPassowrd);
        }

        var claims = new List<Claim>()
        {
            new Claim(ClaimTypes.NameIdentifier, person.Id.ToString()),
            new Claim(ClaimTypes.Email, person.Email),
            new Claim(ClaimTypes.Name, person.Name)
        };

        var accessToken = tokenProvider.GenerateAccessToken(claims);

        var refreshToken = tokenProvider.GenerateRefreshToken();

        person.SetRefreshToken(refreshToken, 30);

        personRepository.Update(person);

        var token = new Token(_tokenHandler.WriteToken(accessToken), refreshToken, person.RefreshTokenExpiresAt!.Value);

        return Result<Token>.Success(token);
    }

    public async Task<Result<Token>> AuthenticateWithRefreshTokenAsync(string token, string refreshToken, CancellationToken cancellationToken)
    {
        var claims = tokenProvider.GetPrincipalFromExpiredToken(token);

        var personEmail = claims.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)!.Value;
        
        var person = await personRepository.GetByEmailAsync(personEmail, cancellationToken);
        
        if(person is null)
        {
            logger.LogInformation("User not found with Email: {Email}", personEmail);

            return Result<Token>.Failure(AuthenticationErrors.NotFoundByEmail);
        }

        if (person.IsRefreshTokenExpired())
        {
            logger.LogInformation("Refresh Token expired for user with Email: {Email}", personEmail);

            return Result<Token>.Failure(AuthenticationErrors.RefreshTokenExpired);
        }

        if (person.RefreshToken != refreshToken)
        {
            logger.LogInformation("Incorrect Refresh Token for user with Email: {Email}", personEmail);

            return Result<Token>.Failure(AuthenticationErrors.IncorrectRefreshToken);
        }
        
        var accessToken = tokenProvider.GenerateAccessToken(claims.Claims);

        var newRefreshToken = tokenProvider.GenerateRefreshToken();

        person.SetRefreshToken(newRefreshToken, 30);

        personRepository.Update(person);

        var newAccessToken = new Token(_tokenHandler.WriteToken(accessToken), newRefreshToken, person.RefreshTokenExpiresAt!.Value);

        return Result<Token>.Success(newAccessToken);
    }
}