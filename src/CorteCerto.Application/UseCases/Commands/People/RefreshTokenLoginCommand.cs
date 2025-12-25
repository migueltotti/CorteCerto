using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using LiteBus.Commands.Abstractions;

namespace CorteCerto.Application.UseCases.Commands.People;

public record RefreshTokenLoginCommand(
    string Token,
    string RefreshToken
) : ICommand<Result<LoginDto>>;