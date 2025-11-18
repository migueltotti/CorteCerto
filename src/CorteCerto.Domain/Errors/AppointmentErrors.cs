using CorteCerto.Domain.Base;
using CorteCerto.Domain.Entities;

namespace CorteCerto.Domain.Errors;

public static class AppointmentErrors
{
    public static Error InvalidDate => new(
        "AppointmentError.InvalidDate",
        "O agendamento deve ser no futuro.");

    public static Error InvalidAppointment => new(
        "AppointmentError.InvalidAppointment",
        "Cliente não pode ser o mesmo que o Barbeiro.");

    public static Error EndTimeCollision => new Error(
        "AppointmentError.NotAvailableAtTime",
        "Horario de finalização do serviço tem colisão com outro agendamento."
    );

    public static Error AppointmentExistsAtTime => new Error(
        "AppointmentError.NotAvailableAtDate",
        "Agendamento já existe para esse horário."
    );

    public static Error ValidationError(string details) => new(
        "AppointmentError.ValidationError",
        details);
}
