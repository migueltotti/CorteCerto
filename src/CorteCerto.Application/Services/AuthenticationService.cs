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

        person.SetRefreshToken(refreshToken, 5);

        personRepository.Update(person);

        var token = new Token(_tokenHandler.WriteToken(accessToken), refreshToken, person.RefreshTokenExpiresAt!.Value);

        return Result<Token>.Success(token);
    }
}