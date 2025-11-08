using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.Interfaces.Repositories;
using FluentValidation;
using LiteBus.Commands.Abstractions;
using Mapster;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace CorteCerto.Application.UseCases.Commands;

public class RegisterServiceCommandHandler(
    IBarberRepository barberRepository,
    IServiceRepository serviceRepository,
    IValidator<RegisterServiceCommand> validator,
    ILogger<RegisterServiceCommandHandler> logger)
    : ICommandHandler<RegisterServiceCommand, Result<ServiceDto>>
{
    public async Task<Result<ServiceDto>> HandleAsync(RegisterServiceCommand command, CancellationToken cancellationToken = default)
    {
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if(!validationResult.IsValid)
        {
            logger.LogInformation("Failed registering service for Barber with BarberId: {BarberId}", command.BarberId);

            return Result<ServiceDto>.Failure(ServiceErrors.ValidationError(JsonSerializer.Serialize(validationResult.Errors)));
        }

        var barber = await barberRepository.Select(command.BarberId);

        if(barber is null)
        {
            logger.LogInformation("Barber with BarberId not found: {BarberId}", command.BarberId);

            return Result<ServiceDto>.Failure(BarberErrors.NotFoundById);
        }

        var serviceResult = Service.Create(
            command.Name,
            command.Description,
            command.Price,
            command.Duration,
            barber
        );

        if (serviceResult.IsFailure)
        {
            logger.LogInformation("Duration invalid for creating service with BarberId: {BarberId}", command.BarberId);

            return Result<ServiceDto>.Failure(serviceResult.Error);
        }

        //barberRepository.AttachObject(barber);
        serviceRepository.Insert(serviceResult.Data);

        logger.LogInformation("Service registred with sucess for Barber with BarberId: {BarberId}", serviceResult.Data.Barber.Id);

        return Result<ServiceDto>.Success(serviceResult.Data.Adapt<ServiceDto>());
    }
}
