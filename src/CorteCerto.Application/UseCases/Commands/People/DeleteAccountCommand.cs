using CorteCerto.Domain.Base;
using LiteBus.Commands.Abstractions;

namespace CorteCerto.Application.UseCases.Commands.People;

public record DeleteAccountCommand(Guid PersonId) : ICommand<Result>;
