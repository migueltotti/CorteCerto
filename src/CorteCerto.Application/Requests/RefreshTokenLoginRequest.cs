namespace CorteCerto.Application.Requests;

public record RefreshTokenLoginRequest(
    string Token,
    string RefreshToken
);