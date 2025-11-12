using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using LiteBus.Commands.Abstractions;

namespace CorteCerto.Application.UseCases.Commands.People;

public record LoginCommand(
    string Email,
    string Password
) : ICommand<Result<LoginDto>>;

