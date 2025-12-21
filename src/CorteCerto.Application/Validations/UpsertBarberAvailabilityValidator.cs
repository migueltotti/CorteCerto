using CorteCerto.Application.UseCases.Commands.Barbers;
using FluentValidation;

namespace CorteCerto.Application.Validations;

public class UpsertBarberAvailabilityValidator : AbstractValidator<UpsertBarberAvailabilityCommand>
{
    public UpsertBarberAvailabilityValidator()
    {
        RuleFor(x => x.Request.BarberId)
            .NotNull().WithMessage("Id do Barbeiro não pode ser nulo.")
            .NotEmpty().WithMessage("Id da Barbeiro é obrigatório.");

        RuleFor(x => x.Request.DayOfWeek)
            .NotNull().WithMessage("Dia da semana não pode ser nulo.")
            .NotEmpty().WithMessage("Dia da semana é obrigatório.");

        RuleFor(x => x.Request.StartTime)
            .NotNull().WithMessage("Hora de inicio não pode ser nulo.")
            .NotEmpty().WithMessage("Hora de inicio é obrigatório.");

        RuleFor(x => x.Request.EndTime)
            .NotNull().WithMessage("Hora de finalização não pode ser nulo.")
            .NotEmpty().WithMessage("Hora de finalização é obrigatório.");
    }
}
