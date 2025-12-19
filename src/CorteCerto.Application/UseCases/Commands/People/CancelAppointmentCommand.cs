using CorteCerto.Application.DTO;
using CorteCerto.Application.Requests;
using CorteCerto.Domain.Base;
using LiteBus.Commands.Abstractions;

namespace CorteCerto.Application.UseCases.Commands.People;

public record CancelAppointmentCommand(Guid AppointmentId, CancelAppointmentRequest Request) : ICommand<Result<AppointmentDto>>;
