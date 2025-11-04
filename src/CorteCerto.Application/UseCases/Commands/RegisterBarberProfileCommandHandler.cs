using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.Helpers;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Domain.Interfaces.Services;
using FluentValidation;
using LiteBus.Commands.Abstractions;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace CorteCerto.Application.UseCases.Commands;

public class RegisterBarberProfileCommandHandler(
    IValidator<RegisterBarberProfileCommand> validator,
    ICustomerRepository customerRepository,
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
            logger.LogInformation("Barber infos validatio failed for PersonId: {PersonId}", command.PersonId);

            return Result<BarberDto>.Failure(CustomerErrors.ValidationError(JsonSerializer.Serialize(validationResult.Errors)));
        }


        var person = await customerRepository.Select(command.PersonId);

        if (person is null)
        {
            logger.LogInformation("Person not found for PersonId: {PersonId}", command.PersonId);

            return Result<BarberDto>.Failure(CustomerErrors.NotFoundById);
        }


        var addressResult = await addressService.CreateAddressByCep(command.Cep.RemoveHifen(), command.AddressNumber);

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
            command.PortfolioUrl ?? String.Empty,
            addressResult.Data
        );

        barberRepository.Insert(barber);

        logger.LogInformation("Barber profile registered successfully for PersonId: {PersonId}", command.PersonId);

        return Result<BarberDto>.Success(
            new BarberDto(
                barber.Id,
                barber.Name,
                barber.Email,
                barber.PhoneNumber
            ));
    }
}
