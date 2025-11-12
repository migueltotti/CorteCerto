using CorteCerto.Domain.Interfaces.Services;
using CorteCerto.Infrastructure.Authentication;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace CorteCerto.UnitTests.Infrastructure;

public class TokenProviderTest
{
    public readonly ITokenProvider tokenProvider;
    private readonly JwtSecurityTokenHandler tokenHandler;

    public TokenProviderTest()
    {
        tokenProvider = new TokenProvider();
        tokenHandler = new JwtSecurityTokenHandler();

        Environment.SetEnvironmentVariable("SECRET_KEY", "piuUGAWduihAI(*!&@#_(!HPIUAGWDIUY(!Y1231`d1231");
        Environment.SetEnvironmentVariable("TOKEN_VALIDITY_IN_MINUTES", "5");
        Environment.SetEnvironmentVariable("VALID_AUDIENCE", "CorteCertoAudience");
        Environment.SetEnvironmentVariable("VALID_ISSUER", "CorteCertoIssuer");
    }

    [Fact]
    public void GenerateAccessToken_ShouldReturnJwtAccessToken()
    {
        // Arrange
        var claims = new List<Claim>()
        {
            new Claim(ClaimTypes.NameIdentifier, Guid.NewGuid().ToString()),
            new Claim(ClaimTypes.Email, "teste@email.com"),
            new Claim(ClaimTypes.Name, "Teste Da Silva")
        };

        // Act
        var jwtToken = tokenProvider.GenerateAccessToken(claims);
        var tokenString = tokenHandler.WriteToken(jwtToken);

        // Assert
        Assert.NotNull(tokenString);
        Assert.NotEmpty(tokenString);
    }

    [Fact]
    public void GenerateRefreshToken_ShouldReturnRefreshToken()
    {
        // Arrange

        // Act
        var refreshToken = tokenProvider.GenerateRefreshToken();

        // Assert
        Assert.NotNull(refreshToken);
        Assert.NotEmpty(refreshToken);
        Assert.Equal(172, refreshToken.Length); // 128 bytes in Base64 results in 172 characters
    }

    [Fact]
    public void GetPrincipalFromExpiredToken_ShouldReturnClaimsPrincipal()
    {
        // Arrange
        var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiJlYWQwZTQ2Ny0wYjhkLTQyMzUtOWM1NS1lYWE3MjRhNDg0NjYiLCJlbWFpbCI6InRlc3RlQGVtYWlsLmNvbSIsInVuaXF1ZV9uYW1lIjoiVGVzdGUgRGEgU2lsdmEiLCJuYmYiOjE3NjI5NDcwMzEsImV4cCI6MTc2Mjk0NzMzMSwiaWF0IjoxNzYyOTQ3MDMxLCJpc3MiOiJDb3J0ZUNlcnRvSXNzdWVyIiwiYXVkIjoiQ29ydGVDZXJ0b0F1ZGllbmNlIn0.NtiE4ccMDdt9hQK6YoNiWSTU_LmQjHQ4elSbmlj1mTk";

        // Act
        var claimsPrincipal = tokenProvider.GetPrincipalFromExpiredToken(token);

        // Assert
        Assert.NotNull(claimsPrincipal);
        Assert.NotEmpty(claimsPrincipal.Claims);
        Assert.Contains("teste@email.com", claimsPrincipal.Claims.Select(c => c.Value));
    }
}
