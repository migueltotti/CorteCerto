using CorteCerto.Application.UseCases.Commands;
using FluentValidation;
using FluentValidation.Validators;
using System.Text.RegularExpressions;

namespace CorteCerto.Application.Validations;

public partial class CreateAccountCommandValidator : AbstractValidator<CreateAccountCommand>
{
    public CreateAccountCommandValidator()
    {
        RuleFor(x => x.Name)
            .NotNull().WithMessage("Nome não pode ser nulo.")
            .NotEmpty().WithMessage("Nome é obrigatório.")
            .MaximumLength(200).WithMessage("Name deve ter no máximo 100 caracteres.");
        RuleFor(x => x.Email)
            .NotNull().WithMessage("Email não pode ser nulo.")
            .NotEmpty().WithMessage("Email é obrigatório.")
            .MaximumLength(200).WithMessage("Email deve ter no máximo 100 caracteres.")
            .EmailAddress(EmailValidationMode.AspNetCoreCompatible).WithMessage("Email deve conter '@'.");
        RuleFor(x => x.PhoneNumber)
            .NotNull().WithMessage("Telefone não pode ser nulo.")
            .NotEmpty().WithMessage("Telefone é obrigatório.")
            .MaximumLength(15).WithMessage("Numero de telefone inválido, verifique a quantidade de digitos.");
        RuleFor(x => x.Password)
            .NotNull().WithMessage("Senha não pode ser nulo.")
            .NotEmpty().WithMessage("Senha é obrigatório.")
            .MinimumLength(8).WithMessage("Senha deve ter no mínimo 8 caracteres.")
            .MaximumLength(15).WithMessage("Senha deve ter no máximo 30 caracteres.")
            .Must(p => HasUpperAndLowerCaracter().IsMatch(p)).WithMessage("Senha deve conter pelo menos uma letra maiuscula e uma letra minuscula.")
            .Must(p => HasNumber().IsMatch(p)).WithMessage("Senha deve conter pelo menos um numero.")
            .Must(p => HasSpecialCharacter().IsMatch(p)).WithMessage("Senha deve conter pelo menos um caracter especial.");
    }

    [GeneratedRegex(@"^(?=.*[a-z])(?=.*[A-Z]).*$")]
    private static partial Regex HasUpperAndLowerCaracter();

    [GeneratedRegex(@"^(?=.*\d).*$")]
    private static partial Regex HasNumber();

    [GeneratedRegex(@"^(?=.*[!@#$%^&*(),.?:{}|<>_\-+=]).*$")]
    private static partial Regex HasSpecialCharacter();
}
