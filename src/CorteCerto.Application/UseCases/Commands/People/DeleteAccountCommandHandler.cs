using CorteCerto.Domain.Base;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.Interfaces.Repositories;
using FluentValidation;
using LiteBus.Commands.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CorteCerto.Application.UseCases.Commands.People;

public class DeleteAccountCommandHandler(
    IPersonRepository personRepository,
    IValidator<DeleteAccountCommand> validator,
    ILogger<DeleteAccountCommandHandler> logger)
    : ICommandHandler<DeleteAccountCommand, Result>
{
    public async Task<Result> HandleAsync(DeleteAccountCommand command, CancellationToken cancellationToken = default)
    {
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
        {
            logger.LogInformation("Invalid informations for deleting Person with PersonId: {PersonId}", command.PersonId);

            return Result<bool>.Failure(PersonErrors.ValidationError(JsonSerializer.Serialize(validationResult.Errors)));
        }

        var person = await personRepository.Select(command.PersonId, null, cancellationToken);

        if (person is null)
        {
            logger.LogInformation("Person not found with PersonId: {PersonId}", command.PersonId);

            return Result<bool>.Failure(PersonErrors.NotFoundById);
        }

        personRepository.Delete(person);

        logger.LogInformation("Person with PersonId: {PersonId} deleted successfully", command.PersonId);

        return Result.Success();
    }
}
