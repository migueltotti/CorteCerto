namespace CorteCerto.Application.Requests;

public record RegisterAppointmentRequest(
    Guid BarberId,
    Guid CustomerId,
    int ServiceId,
    DateTime Date
);