using CorteCerto.Domain.Enums;

namespace CorteCerto.Application.DTO;

public record AppointmentDto(
    Guid Id,
    DateTime Date,
    AppointmentStatus Status,
    TimeSpan ResponseDeadline,
    CustomerDto Customer,
    BarberDto Barber,
    ServiceDto Service
);
