using CorteCerto.Domain.Enums;

namespace CorteCerto.Application.DTO;

public record AppointmentDto(
    Guid Id,
    DateTime Date,
    AppointmentStatus Status,
    TimeSpan ResponseDeadline,
    AppointmentCustomerDto Customer,
    AppointmentBarberDto Barber,
    AppointmentServiceDto Service
);

public record AppointmentBarberDto(
    Guid Id,
    string Name,
    AddressDto Address
);

public record AppointmentCustomerDto(
    Guid Id,
    string Name
);

public record AppointmentServiceDto(
    int Id,
    string Name,
    double Price,
    TimeSpan Duration
);
