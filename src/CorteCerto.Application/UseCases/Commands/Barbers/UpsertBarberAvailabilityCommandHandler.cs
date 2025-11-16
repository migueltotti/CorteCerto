using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Domain.ValueObjects;
using FluentValidation;
using LiteBus.Commands.Abstractions;
using Mapster;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace CorteCerto.Application.UseCases.Commands.Barbers;

public class UpsertBarberAvailabilityCommandHandler(
    IBarberRepository barberRepository,
    IValidator<UpsertBarberAvailabilityCommand> validator,
    ILogger<UpsertBarberAvailabilityCommandHandler> logger)
    : ICommandHandler<UpsertBarberAvailabilityCommand, Result<BarberDto>>
{
    public async Task<Result<BarberDto>> HandleAsync(UpsertBarberAvailabilityCommand command, CancellationToken cancellationToken = default)
    {
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
        {
            logger.LogInformation("Barber Availability infos validation failed for Barber with BarberId: {BarberId}", command.BarberId);

            return Result<BarberDto>.Failure(BarberErrors.ValidationError(JsonSerializer.Serialize(validationResult.Errors)));
        }

        var barber = await barberRepository.Select(command.BarberId, ["Availabilities"], cancellationToken);

        if (barber is null)
        {
            logger.LogInformation("Barber not found for BarberId: {BarberId}", command.BarberId);

            return Result<BarberDto>.Failure(BarberErrors.NotFoundById);
        }

        var availabilityResult = BarberAvailability.Create(
            command.DayOfWeek,
            command.StartTime,
            command.EndTime);

        if (availabilityResult.IsFailure)
        {
            logger.LogInformation("Barber Availability creation failed for BarberId: {BarberId}", command.BarberId);

            return Result<BarberDto>.Failure(availabilityResult.Error);
        }

        barber.UpsertAvailability(availabilityResult.Data);

        barberRepository.Update(barber);

        logger.LogInformation("Availability created successfully for BarberId: {BarberId}", command.BarberId);

        var barberResponse = barber.Adapt<BarberDto>();

        return Result<BarberDto>.Success(barberResponse);
    }
}
