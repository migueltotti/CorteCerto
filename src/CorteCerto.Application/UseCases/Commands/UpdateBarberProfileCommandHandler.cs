using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.Interfaces.Repositories;
using FluentValidation;
using LiteBus.Commands.Abstractions;
using Mapster;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace CorteCerto.Application.UseCases.Commands;

public class UpdateBarberProfileCommandHandler(
    IBarberRepository barberRepository,
    IValidator<UpdateBarberProfileCommand> validator,
    ILogger<UpdateBarberProfileCommandHandler> logger)
    : ICommandHandler<UpdateBarberProfileCommand, Result<BarberDto>>
{
    public async Task<Result<BarberDto>> HandleAsync(UpdateBarberProfileCommand command, CancellationToken cancellationToken = default)
    {
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
        {
            logger.LogInformation("Invalid informations for updating Barber profile with BarberId: {BarberId}", command.BarberId);

            return Result<BarberDto>.Failure(BarberErrors.ValidationError(JsonSerializer.Serialize(validationResult.Errors)));
        }

        var barber = await barberRepository.Select(command.BarberId);

        if (barber is null)
        {
            logger.LogInformation("Barber with BarberId: {BarberId} not found.", command.BarberId);

            return Result<BarberDto>.Failure(BarberErrors.NotFoundById);
        }

        barber = barber
            .SetName(command.Name)
            .SetDescription(command.Description)
            .SetPortifolioUrl(command.PortfolioUrl)
            .SetPhoneNumber(command.PhoneNumber);

        barberRepository.Update(barber);

        logger.LogInformation("Barber profile updated sucessfully with BarberId: {BarberId}", barber.Id);

        return Result<BarberDto>.Success(barber.Adapt<BarberDto>());
    }
}
