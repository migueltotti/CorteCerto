using CorteCerto.Application.UseCases.Commands.People;
using FluentValidation;

namespace CorteCerto.Application.Validations;

public class RefreshTokenLoginValidator : AbstractValidator<RefreshTokenLoginCommand>
{
    public RefreshTokenLoginValidator()
    {
        RuleFor(x => x.Token)
            .NotNull().WithMessage("Token de acesso não pode ser nulo.")
            .NotEmpty().WithMessage("Token de acesso é obrigatório.");

        RuleFor(x => x.RefreshToken)
            .NotNull().WithMessage("Refresh Token não pode ser nulo.")
            .NotEmpty().WithMessage("Refresh Token é obrigatório.");
    }
}