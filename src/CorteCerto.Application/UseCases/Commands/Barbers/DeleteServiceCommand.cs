using CorteCerto.Domain.Base;
using LiteBus.Commands.Abstractions;
using System.Windows.Input;

namespace CorteCerto.Application.UseCases.Commands.Barbers;

public record DeleteServiceCommand(
    Guid BarberId,
    int ServiceId
) : ICommand<Result>;
