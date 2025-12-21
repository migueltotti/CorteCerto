using CorteCerto.Application.UseCases.Commands.Customers;
using FluentValidation;

namespace CorteCerto.Application.Validations;

public class ScheduleBarberServiceValidator : AbstractValidator<ScheduleBarberServiceCommand>
{
    public ScheduleBarberServiceValidator()
    {
        RuleFor(x => x.Request.BarberId)
            .NotNull().WithMessage("Id do Barbeiro não pode ser nulo.")
            .NotEmpty().WithMessage("Id do Barbeiro é obrigatório.");

        RuleFor(x => x.Request.CustomerId)
            .NotNull().WithMessage("Id do Cliente não pode ser nulo.")
            .NotEmpty().WithMessage("Id do Cliente é obrigatório.");

        RuleFor(x => x.Request.ServiceId)
            .NotNull().WithMessage("Id do Serviço não pode ser nulo.")
            .NotEmpty().WithMessage("Id do Serviço é obrigatório.")
            .GreaterThan(0).WithMessage("Id do Serviço não pode ser negativo.");

        RuleFor(x => x.Request.Date)
            .NotNull().WithMessage("Data não pode ser nulo.")
            .NotEmpty().WithMessage("Data é obrigatória.");
    }
}
