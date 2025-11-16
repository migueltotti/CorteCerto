namespace CorteCerto.Domain.Responses;

public record Token(
    string AccessToken,
    string RefreshToken,
    DateTime RefreshTokenExpiresAt
);
