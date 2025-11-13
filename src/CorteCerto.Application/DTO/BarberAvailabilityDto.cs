using CorteCerto.Domain.Entities;

namespace CorteCerto.Application.DTO;

public record BarberAvailabilityDto(
    DayOfWeek DayOfWeek,
    DateTime StartTime,
    DateTime EndTime
);