using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using LiteBus.Commands.Abstractions;

namespace CorteCerto.Application.UseCases.Commands.Barbers;

public record UpdateServiceCommand(
    Guid BarberId,
    int ServiceId,
    string Name,
    string Description,
    decimal Price,
    TimeSpan Duration,
    bool IsAvailable
) : ICommand<Result<ServiceDto>>;
