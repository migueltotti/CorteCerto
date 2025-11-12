
namespace CorteCerto.Application.DTO;

public record LoginDto(
    string AccessToken,
    string RefreshToken,
    DateTime RefreshTokenExpiresAt
);
