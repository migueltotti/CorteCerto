using CorteCerto.Domain.Base;

namespace CorteCerto.Domain.Errors;

public static class AuthenticationErrors
{
    public static Error NotFoundByEmail => new(
        "AuthenticationError.NotFoundByEmail",
        "Cliente com esse Id não encontrado.");

    public static Error IncorrectPassowrd => new Error(
        "AuthenticationError.IncorrectPassword", 
        "Senha incorreta.");
    
    public static Error RefreshTokenExpired => new Error(
        "AuthenticationError.RefreshTokenExpired", 
        "Refresh Token expirado.");
    
    public static Error IncorrectRefreshToken => new Error(
        "AuthenticationError.IncorrectRefreshToken", 
        "Refresh Token incorreto.");
    
    public static Error LoginValidationError(string details) => new(
        "AuthenticationError.LoginValidationError",
        details);
}
