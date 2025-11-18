using CorteCerto.Application.UseCases.Commands.Customers;
using FluentValidation;

namespace CorteCerto.Application.Validations;

public class ScheduleBarberServiceValidator : AbstractValidator<ScheduleBarberServiceCommand>
{
    public ScheduleBarberServiceValidator()
    {
        RuleFor(x => x.BarberId)
            .NotNull().WithMessage("Id do Barbeiro não pode ser nulo.")
            .NotEmpty().WithMessage("Id do Barbeiro é obrigatório.");

        RuleFor(x => x.CustomerId)
            .NotNull().WithMessage("Id do Cliente não pode ser nulo.")
            .NotEmpty().WithMessage("Id do Cliente é obrigatório.");

        RuleFor(x => x.ServiceId)
            .NotNull().WithMessage("Id do Serviço não pode ser nulo.")
            .NotEmpty().WithMessage("Id do Serviço é obrigatório.")
            .GreaterThan(0).WithMessage("Id do Serviço não pode ser negativo.");

        RuleFor(x => x.Date)
            .NotNull().WithMessage("Data não pode ser nulo.")
            .NotEmpty().WithMessage("Data é obrigatória.");
    }
}
