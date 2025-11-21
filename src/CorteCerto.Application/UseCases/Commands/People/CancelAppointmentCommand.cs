using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using LiteBus.Commands.Abstractions;

namespace CorteCerto.Application.UseCases.Commands.People;

public record CancelAppointmentCommand(Guid AppointmentId, Guid BarberId, Guid CustomerId) : ICommand<Result<AppointmentDto>>;
