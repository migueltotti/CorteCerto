using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace CorteCerto.Domain.Interfaces.Services;

public interface ITokenProvider
{
    JwtSecurityToken GenerateAccessToken(IEnumerable<Claim> claims);
    string GenerateRefreshToken();
    ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
}
