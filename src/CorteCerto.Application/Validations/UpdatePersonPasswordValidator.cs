using CorteCerto.Application.UseCases.Commands;
using CorteCerto.Domain.Helpers;
using FluentValidation;

namespace CorteCerto.Application.Validations;

public class UpdatePersonPasswordValidator : AbstractValidator<UpdatePersonPasswordCommand>
{
    public UpdatePersonPasswordValidator()
    {
        RuleFor(p => p.PersonId)
            .NotNull().WithMessage("Id da conta não pode ser nulo.")
            .NotEmpty().WithMessage("Id da conta é obrigatório.");

        RuleFor(x => x.CurrentPassword)
            .NotNull().WithMessage("Senha não pode ser nulo.")
            .NotEmpty().WithMessage("Senha é obrigatório.")
            .MinimumLength(8).WithMessage("Senha deve ter no mínimo 8 caracteres.")
            .MaximumLength(15).WithMessage("Senha deve ter no máximo 30 caracteres.")
            .Must(p => PasswordHelper.HasUpperAndLowerCaracter.IsMatch(p)).WithMessage("Senha atual deve conter pelo menos uma letra maiuscula e uma letra minuscula.")
            .Must(p => PasswordHelper.HasNumber.IsMatch(p)).WithMessage("Senha deve conter pelo menos um numero.")
            .Must(p => PasswordHelper.HasSpecialCharacter.IsMatch(p)).WithMessage("Senha deve conter pelo menos um caracter especial.");

        RuleFor(x => x.NewPassword)
            .NotNull().WithMessage("Senha não pode ser nulo.")
            .NotEmpty().WithMessage("Senha é obrigatório.")
            .MinimumLength(8).WithMessage("Senha deve ter no mínimo 8 caracteres.")
            .MaximumLength(15).WithMessage("Senha deve ter no máximo 30 caracteres.")
            .Must(p => PasswordHelper.HasUpperAndLowerCaracter.IsMatch(p)).WithMessage("Senha deve conter pelo menos uma letra maiuscula e uma letra minuscula.")
            .Must(p => PasswordHelper.HasNumber.IsMatch(p)).WithMessage("Senha deve conter pelo menos um numero.")
            .Must(p => PasswordHelper.HasSpecialCharacter.IsMatch(p)).WithMessage("Senha deve conter pelo menos um caracter especial.");
    }
}
