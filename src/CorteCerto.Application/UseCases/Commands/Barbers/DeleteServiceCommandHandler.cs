using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.Interfaces.Repositories;
using FluentValidation;
using LiteBus.Commands.Abstractions;
using Mapster;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace CorteCerto.Application.UseCases.Commands.Barbers;

public class DeleteServiceCommandHandler(
    IBarberRepository barberRepository,
    IValidator<DeleteServiceCommand> validator,
    ILogger<DeleteServiceCommandHandler> logger)
    : ICommandHandler<DeleteServiceCommand, Result>
{
    public async Task<Result> HandleAsync(DeleteServiceCommand command, CancellationToken cancellationToken = default)
    {
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
        {
            logger.LogInformation("Delete Barber Service validation failed for Barber with BarberId: {BarberId} and Service with ServiceId: {}", command.BarberId, command.ServiceId);

            return Result.Failure(BarberErrors.ValidationError(JsonSerializer.Serialize(validationResult.Errors)));
        }

        var barber = await barberRepository.Select(command.BarberId, ["Services"], cancellationToken);

        if (barber is null)
        {
            logger.LogInformation("Barber not found for BarberId: {BarberId}", command.BarberId);

            return Result.Failure(BarberErrors.NotFoundById);
        }

        var service = barber.GetService(command.ServiceId);

        if (service is null)
        {
            logger.LogInformation("Service with ServiceId: {ServiceId} not found for BarberId: {BarberId}", command.ServiceId, command.BarberId);

            return Result.Failure(BarberErrors.ServiceNotFound);
        }

        barber.RemoveService(command.ServiceId);

        barberRepository.Update(barber);

        logger.LogInformation("Service with ServiceId: {ServiceId} deleted successfully for BarberId: {BarberId}", command.ServiceId, command.BarberId);

        return Result.Success();
    }
}
