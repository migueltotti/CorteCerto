using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.Interfaces.Repositories;
using FluentValidation;
using LiteBus.Commands.Abstractions;
using Mapster;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace CorteCerto.Application.UseCases.Commands.People;

public class UpdateProfileInfoCommandHandler(
    IPersonRepository personRepository,
    ICustomerRepository customerRepository,
    IValidator<UpdateProfileInfoCommand> validator,
    ILogger<UpdateProfileInfoCommandHandler> logger) : ICommandHandler<UpdateProfileInfoCommand, Result<CustomerDto>>
{
    public async Task<Result<CustomerDto>> HandleAsync(UpdateProfileInfoCommand command, CancellationToken cancellationToken = default)
    {
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
        {
            logger.LogInformation("Invalid informations for updating Profile Info for PersonId: {PersonId}", command.PersonId);

            return Result<CustomerDto>.Failure(PersonErrors.ValidationError(JsonSerializer.Serialize(validationResult.Errors)));
        }

        var person = await personRepository.Select(command.PersonId, null, cancellationToken);

        if (person is null)
        {
            logger.LogInformation("Person not found with PersonId: {PersonId}", command.PersonId);

            return Result<CustomerDto>.Failure(PersonErrors.NotFoundById);
        }

        person.UpdateName(command.NewName);
        person.UpdatePhoneNumber(command.NewPhoneNumber);

        personRepository.Update(person);

        var customer = await customerRepository.Select(command.PersonId, token: cancellationToken);

        return Result<CustomerDto>.Success(customer.Adapt<CustomerDto>());
    }
}