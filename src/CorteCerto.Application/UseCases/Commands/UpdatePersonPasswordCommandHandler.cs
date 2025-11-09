using CorteCerto.Domain.Base;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Domain.Interfaces.Services;
using FluentValidation;
using LiteBus.Commands.Abstractions;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace CorteCerto.Application.UseCases.Commands;

public class UpdatePersonPasswordCommandHandler(
    IPersonRepository personRepository,
    IValidator<UpdatePersonPasswordCommand> validator,
    IPasswordHashService passwordService,
    ILogger<UpdatePersonPasswordCommandHandler> logger)
    : ICommandHandler<UpdatePersonPasswordCommand, Result<bool>>
{
    public async Task<Result<bool>> HandleAsync(UpdatePersonPasswordCommand command, CancellationToken cancellationToken = default)
    {
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
        {
            logger.LogInformation("Invalid informations for updating Password for PersonId: {PersonId}", command.PersonId);

            return Result<bool>.Failure(PersonErrors.ValidationError(JsonSerializer.Serialize(validationResult.Errors)));
        }

        var person = await personRepository.Select(command.PersonId, null, cancellationToken);

        if (person is null)
        {
            logger.LogInformation("Person not found with PersonId: {PersonId}", command.PersonId);

            return Result<bool>.Failure(PersonErrors.NotFoundById);
        }

        if (!passwordService.Verify(command.CurrentPassword, person.PasswordHash))
        {
            logger.LogInformation("Current password missmatch for Person with PersonId: {PersonId}", command.PersonId);

            return Result<bool>.Failure(PersonErrors.PasswordMismatch);
        }

        var newHashedPassword = passwordService.Hash(command.NewPassword);

        var updatePasswordHashResult = person.UpadtePasswordHash(newHashedPassword);

        if (updatePasswordHashResult.IsFailure)
        {
            logger.LogInformation("Invalid PasswordHash format for Person with PersonId: {PersonId}", command.PersonId);

            return Result<bool>.Failure(updatePasswordHashResult.Error);
        }

        personRepository.Update(person);

        return Result<bool>.Success(true);
    }
}
