using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using LiteBus.Commands.Abstractions;

namespace CorteCerto.Application.UseCases.Commands.Barbers;

public record CompleteAppointmentCommand(Guid AppointmentId, Guid BarberId) : ICommand<Result<AppointmentDto>>;
