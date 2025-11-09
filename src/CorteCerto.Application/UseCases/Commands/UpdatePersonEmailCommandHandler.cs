

using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.Interfaces.Repositories;
using FluentValidation;
using LiteBus.Commands.Abstractions;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace CorteCerto.Application.UseCases.Commands;

public class UpdatePersonEmailCommandHandler(
    IPersonRepository personRepository,
    IValidator<UpdatePersonEmailCommand> validator,
    ILogger<UpdatePersonEmailCommandHandler> logger)
    : ICommandHandler<UpdatePersonEmailCommand, Result<bool>>
{
    public async Task<Result<bool>> HandleAsync(UpdatePersonEmailCommand command, CancellationToken cancellationToken = default)
    {
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
        {
            logger.LogInformation("Invalid informations for updating Email with PersonId: {PersonId}", command.PersonId);

            return Result<bool>.Failure(PersonErrors.ValidationError(JsonSerializer.Serialize(validationResult.Errors)));
        }

        var person = await personRepository.Select(command.PersonId, null, cancellationToken);

        if (person is null)
        {
            logger.LogInformation("Person not found with PersonId: {PersonId}", command.PersonId);

            return Result<bool>.Failure(PersonErrors.NotFoundById);
        }

        if (!person.IsCurrentEmail(command.CurrentEmail))
        {
            logger.LogInformation("Current email missmatch for Person with PersonId: {PersonId}", command.PersonId);

            return Result<bool>.Failure(PersonErrors.EmailMismatch);
        }

        person.UpadteEmail(command.NewEmail);

        personRepository.Update(person);

        return Result<bool>.Success(true);
    }
}
