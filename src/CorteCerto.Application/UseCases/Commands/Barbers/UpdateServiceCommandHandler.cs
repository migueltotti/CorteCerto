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

namespace CorteCerto.Application.UseCases.Commands.Barbers;

public class UpdateServiceCommandHandler(
    IBarberRepository barberRepository,
    IValidator<UpdateServiceCommand> validator,
    ILogger<UpdateServiceCommandHandler> logger)
    : ICommandHandler<UpdateServiceCommand, Result<ServiceDto>>
{
    public async Task<Result<ServiceDto>> HandleAsync(UpdateServiceCommand command, CancellationToken cancellationToken = default)
    {
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
        {
            logger.LogInformation("Update Barber Service validation failed for Barber with BarberId: {BarberId}", command.BarberId);

            return Result<ServiceDto>.Failure(BarberErrors.ValidationError(JsonSerializer.Serialize(validationResult.Errors)));
        }

        var barber = await barberRepository.Select(command.BarberId, ["Services"], cancellationToken);

        if (barber is null)
        {
            logger.LogInformation("Barber not found for BarberId: {BarberId}", command.BarberId);

            return Result<ServiceDto>.Failure(BarberErrors.NotFoundById);
        }

        var service = barber.GetService(command.ServiceId);

        if (service is null)
        {
            logger.LogInformation("Service not found for BarberId: {BarberId}", command.BarberId);

            return Result<ServiceDto>.Failure(BarberErrors.ServiceNotFound);
        }

        service.Update(
            command.Name,
            command.Description,
            command.Price,
            command.Duration,
            command.IsAvailable);

        barber.UpdateService(service);

        barberRepository.Update(barber);

        logger.LogInformation("Service updated successfully for BarberId: {BarberId}", command.BarberId);

        var serviceResponse = service.Adapt<ServiceDto>();

        return Result<ServiceDto>.Success(serviceResponse);
    }
}
