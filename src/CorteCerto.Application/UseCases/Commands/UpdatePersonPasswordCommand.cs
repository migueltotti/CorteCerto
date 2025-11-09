using CorteCerto.Domain.Base;
using LiteBus.Commands.Abstractions;

namespace CorteCerto.Application.UseCases.Commands;

public record UpdatePersonPasswordCommand(
    Guid PersonId,
    string CurrentPassword,
    string NewPassword
) : ICommand<Result<bool>>;
