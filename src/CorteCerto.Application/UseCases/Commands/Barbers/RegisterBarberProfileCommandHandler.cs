using System.Text.Json;
using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Domain.Interfaces.Services;
using FluentValidation;
using LiteBus.Commands.Abstractions;
using Mapster;
using Microsoft.Extensions.Logging;
using Barber = CorteCerto.Domain.Entities.Barber;

namespace CorteCerto.Application.UseCases.Commands.Barbers;

public class RegisterBarberProfileCommandHandler(
    IValidator<RegisterBarberProfileCommand> validator,
    IPersonRepository personRepository,
    IBarberRepository barberRepository,
    IAddressService addressService,
    ILogger<RegisterBarberProfileCommandHandler> logger)
    : ICommandHandler<RegisterBarberProfileCommand, Result<BarberDto>>
{
    public async Task<Result<BarberDto>> HandleAsync(RegisterBarberProfileCommand command, CancellationToken cancellationToken = default)
    {
        var validationResult = await validator.ValidateAsync(command, cancellationToken);   

        if (!validationResult.IsValid)
        {
            logger.LogInformation("Barber infos validation failed for PersonId: {PersonId}", command.PersonId);

            return Result<BarberDto>.Failure(CustomerErrors.ValidationError(JsonSerializer.Serialize(validationResult.Errors)));
        }

        var person = await personRepository.Select(command.PersonId, token: cancellationToken);

        if (person is null)
        {
            logger.LogInformation("Person not found for PersonId: {PersonId}", command.PersonId);

            return Result<BarberDto>.Failure(CustomerErrors.NotFoundById);
        }

        var addressResult = await addressService.CreateAddressByCep(command.Cep, command.AddressNumber);

        if (addressResult.IsFailure)
        {
            logger.LogInformation("Address not found for Cep: {Cep}", command.Cep);

            return Result<BarberDto>.Failure(addressResult.Error);
        }

        var barber = new Barber(
            person.Id,
            person.Name,
            person.Email,
            person.PhoneNumber,
            person.PasswordHash,
            command.Description,
            command.PortfolioUrl ?? string.Empty,
            addressResult.Data
        );

        await barberRepository.RegisterBarber(barber);

        logger.LogInformation("Barber profile registered successfully for PersonId: {PersonId}", command.PersonId);

        return Result<BarberDto>.Success(barber.Adapt<BarberDto>());
    }
}
