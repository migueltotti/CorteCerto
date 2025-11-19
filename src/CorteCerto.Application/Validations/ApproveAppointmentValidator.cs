using CorteCerto.Application.UseCases.Commands.Barbers;
using FluentValidation;

namespace CorteCerto.Application.Validations;

public class ApproveAppointmentValidator : AbstractValidator<ApproveAppointmentCommand>
{
    public ApproveAppointmentValidator()
    {
        RuleFor(x => x.AppointmentId)
            .NotNull().WithMessage("Id do Agendamento não pode ser nulo.")
            .NotEmpty().WithMessage("Id do Agendamento é obrigatório.");

        RuleFor(x => x.BarberId)
            .NotNull().WithMessage("Id do Barbeiro não pode ser nulo.")
            .NotEmpty().WithMessage("Id do Barbeiro é obrigatório.");
    }
}
