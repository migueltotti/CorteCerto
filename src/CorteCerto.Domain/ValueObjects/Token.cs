
namespace CorteCerto.Domain.ValueObjects;

public record Token(
    string AccessToken,
    string RefreshToken,
    DateTime RefreshTokenExpiresAt
);
