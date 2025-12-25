using System.Text.Json;
using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.Interfaces.Services;
using FluentValidation;
using LiteBus.Commands.Abstractions;
using Mapster;
using Microsoft.Extensions.Logging;

namespace CorteCerto.Application.UseCases.Commands.People;

public class RefreshTokenLoginCommandHandler(
    IAuthenticationService authenticationService,
    IValidator<RefreshTokenLoginCommand> validator,
    ILogger<RefreshTokenLoginCommandHandler> logger)
    : ICommandHandler<RefreshTokenLoginCommand, Result<LoginDto>>
{
    public async Task<Result<LoginDto>> HandleAsync(RefreshTokenLoginCommand command, CancellationToken cancellationToken = new CancellationToken())
    {
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
        {
            logger.LogInformation("Refresh Token Login infos validation failed.");

            return Result<LoginDto>.Failure(AuthenticationErrors.LoginValidationError(JsonSerializer.Serialize(validationResult.Errors)));
        }

        var authenticationResult = await authenticationService.AuthenticateWithRefreshTokenAsync(
            command.Token, 
            command.RefreshToken,
            cancellationToken);

        if (authenticationResult.IsFailure)
            return Result<LoginDto>.Failure(authenticationResult.Error);

        return Result<LoginDto>.Success(authenticationResult.Data.Adapt<LoginDto>());
    }
}