using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using LiteBus.Commands.Abstractions;

namespace CorteCerto.Application.UseCases.Commands.Customers;

public record ScheduleBarberServiceCommand(
    Guid BarberId,
    Guid CustomerId,
    int ServiceId,
    DateTime Date
) : ICommand<Result<AppointmentDto>>;
