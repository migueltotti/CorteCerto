namespace CorteCerto.Application.Requests;

public record RegisterAppointmentRequest(
    Guid BarberId,
    Guid CustomerId,
    int ServiceId,
    AppointmentDate Date
);

public record AppointmentDate(
    DateOnly Date,
    TimeOnly Time,
    string Timezone
);