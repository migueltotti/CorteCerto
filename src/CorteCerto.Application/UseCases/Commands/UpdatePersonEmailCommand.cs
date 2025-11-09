
using CorteCerto.Domain.Base;
using LiteBus.Commands.Abstractions;

namespace CorteCerto.Application.UseCases.Commands;

public record UpdatePersonEmailCommand(
    Guid PersonId,
    string CurrentEmail,    
    string NewEmail
) : ICommand<Result<bool>>;
