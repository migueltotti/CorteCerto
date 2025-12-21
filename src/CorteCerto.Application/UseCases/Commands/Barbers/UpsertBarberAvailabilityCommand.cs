using CorteCerto.Application.DTO;
using CorteCerto.Application.Requests;
using CorteCerto.Domain.Base;
using LiteBus.Commands.Abstractions;

namespace CorteCerto.Application.UseCases.Commands.Barbers;

public record UpsertBarberAvailabilityCommand(UpsertBarberAvailabilityRequest Request) : ICommand<Result<BarberDto>>;
