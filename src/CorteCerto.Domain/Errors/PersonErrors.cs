using CorteCerto.Domain.Base;

namespace CorteCerto.Domain.Errors;

public static class PersonErrors
{
    public static Error NotFoundById => new Error(
        "PersonError.NotFoundById",
        "Pessoa com esse Id não encontrada."
    );

    public static Error EmailMismatch => new Error(
        "PersonError.EmailMismatch",
        "Email não corresponde ao email atual."
    );

    public static Error PasswordMismatch => new Error(
        "PersonError.PasswordMismatch",
        "Senha não corresponde à senha atual."
    );

    public static Error InvalidPasswordHashFormat => new Error(
        "PersonError.InvalidPasswordHashFormat",
        "PasswordHash com formato inválido, deve ser feito o hash da senha!"
    );

    public static Error ValidationError(string details) => new(
        "PersonError.ValidationError",
        details);
}
