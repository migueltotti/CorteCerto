using CorteCerto.Application.UseCases.Commands.Barbers;
using FluentValidation;

namespace CorteCerto.Application.Validations;

public class DeleteServiceValidator : AbstractValidator<DeleteServiceCommand>
{
    public DeleteServiceValidator()
    {
        RuleFor(x => x.BarberId)
        .NotNull().WithMessage("Id do barbeiro não pode ser nulo.")
        .NotEmpty().WithMessage("Id do barbeiro é obrigatório.");

        RuleFor(x => x.ServiceId)
            .NotNull().WithMessage("Id do serviço não pode ser nulo.")
            .NotEmpty().WithMessage("Id do serviço é obrigatório.")
            .GreaterThan(0).WithMessage("Id do serviço não pode ser negativo.");
    }
}
