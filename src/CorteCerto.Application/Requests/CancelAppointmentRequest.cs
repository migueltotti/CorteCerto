namespace CorteCerto.Application.Requests;

public record CancelAppointmentRequest(Guid BarberId, Guid CustomerId);