using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using LiteBus.Commands.Abstractions;

namespace CorteCerto.Application.UseCases.Commands.Barbers;

public record UpsertBarberAvailabilityCommand(
    Guid BarberId,
    DayOfWeek DayOfWeek,
    DateTime StartTime,
    DateTime EndTime
) : ICommand<Result<BarberDto>>;
