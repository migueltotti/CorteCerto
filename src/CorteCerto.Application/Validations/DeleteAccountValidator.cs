using CorteCerto.Application.UseCases.Commands.People;
using FluentValidation;

namespace CorteCerto.Application.Validations;

public class DeleteAccountValidator : AbstractValidator<DeleteAccountCommand>
{
    public DeleteAccountValidator()
    {
        RuleFor(x => x.PersonId)
            .NotNull().WithMessage("Id da conta não pode ser nulo.")
            .NotEmpty().WithMessage("Id da conta é obrigatório.");
    }
}
