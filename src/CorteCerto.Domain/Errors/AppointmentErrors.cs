using CorteCerto.Domain.Base;
using CorteCerto.Domain.Entities;

namespace CorteCerto.Domain.Errors;

public static class AppointmentErrors
{
    public static Error NotFoundById => new Error(
        "AppointmentError.NotFoundById",
        "Agendamento com esse Id não encontrado."
    );

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

    public static Error BarberIdMismatch => new Error(
        "AppointmentError.BarberIdMismatch",
        "Barbeiro não corresponde ao barbeiro do Agendamento."
    );

    public static Error AprovementFailed => new Error(
        "AppointmentError.AprovementFailed",
        "Agendamento deve estar em \"Esperando por Aprovação\" para ser aprovado."
    );

    public static Error ValidationError(string details) => new(
        "AppointmentError.ValidationError",
        details);
}
