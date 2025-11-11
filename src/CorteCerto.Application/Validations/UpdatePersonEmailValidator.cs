using CorteCerto.Application.UseCases.Commands.People;
using FluentValidation;
using FluentValidation.Validators;

namespace CorteCerto.Application.Validations;

public class UpdatePersonEmailValidator : AbstractValidator<UpdatePersonEmailCommand>
{
    public UpdatePersonEmailValidator()
    {
        RuleFor(p => p.PersonId)
            .NotNull().WithMessage("Id da conta não pode ser nulo.")
            .NotEmpty().WithMessage("Id da conta é obrigatório.");

        RuleFor(x => x.CurrentEmail)
            .NotNull().WithMessage("Email atual não pode ser nulo.")
            .NotEmpty().WithMessage("Email atual é obrigatório.")
            .MaximumLength(200).WithMessage("Email atual deve ter no máximo 100 caracteres.")
            .EmailAddress(EmailValidationMode.AspNetCoreCompatible).WithMessage("Email atual deve conter '@'.");

        RuleFor(x => x.NewEmail)
            .NotNull().WithMessage("Novo Email não pode ser nulo.")
            .NotEmpty().WithMessage("Novo Email é obrigatório.")
            .MaximumLength(200).WithMessage("Novo Email deve ter no máximo 100 caracteres.")
            .EmailAddress(EmailValidationMode.AspNetCoreCompatible).WithMessage("Novo Email deve conter '@'.");
    }
}
