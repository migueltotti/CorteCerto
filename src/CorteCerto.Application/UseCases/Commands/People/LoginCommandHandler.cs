using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Domain.Interfaces.Services;
using FluentValidation;
using LiteBus.Commands.Abstractions;
using Mapster;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace CorteCerto.Application.UseCases.Commands.People;

public class LoginCommandHandler(
    IPersonRepository personRepository,
    IValidator<LoginCommand> validator,
    IAuthenticationService authenticationService,
    ILogger<LoginCommandHandler> logger
    ) : ICommandHandler<LoginCommand, Result<LoginDto>>
{
    public async Task<Result<LoginDto>> HandleAsync(LoginCommand command, CancellationToken cancellationToken = default)
    {
        var validationResult = validator.Validate(command);

        if (!validationResult.IsValid)
        {
            logger.LogInformation("Login infos validation failed for Person with Email: {Email}", command.Email);

            return Result<LoginDto>.Failure(AuthenticationErrors.LoginValidationError(JsonSerializer.Serialize(validationResult.Errors)));
        }

        var person = await personRepository.GetByEmailAsync(command.Email, cancellationToken);

        if (person is null)
        {
            logger.LogInformation("Person not found for Email: {Email}", command.Email);

            return Result<LoginDto>.Failure(AuthenticationErrors.NotFoundByEmail);
        }

        var authenticationResult = authenticationService.Authenticate(person, command.Password);

        if(authenticationResult.IsFailure)
            return Result<LoginDto>.Failure(authenticationResult.Error);

        return Result<LoginDto>.Success(authenticationResult.Data.Adapt<LoginDto>());
    }
}
