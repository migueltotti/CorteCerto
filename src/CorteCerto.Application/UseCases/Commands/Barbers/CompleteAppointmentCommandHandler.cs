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

public class CompleteAppointmentCommandHandler(
    IAppointmentRepository appointmentRepository,
    IValidator<CompleteAppointmentCommand> validator,
    ILogger<CompleteAppointmentCommandHandler> logger) : ICommandHandler<CompleteAppointmentCommand, Result<AppointmentDto>>
{
    public async Task<Result<AppointmentDto>> HandleAsync(CompleteAppointmentCommand command, CancellationToken cancellationToken = default)
    {
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
        {
            logger.LogInformation("Appointment complete validation failed for AppointmentId: {AppointmentId}", command.AppointmentId);

            return Result<AppointmentDto>.Failure(AppointmentErrors.ValidationError(JsonSerializer.Serialize(validationResult.Errors)));
        }

        var appointment = await appointmentRepository.Select(command.AppointmentId, ["Barber"], cancellationToken);

        if (appointment is null)
        {
            logger.LogInformation("Appointment not found with AppointmentId: {AppointmentId}", command.AppointmentId);

            return Result<AppointmentDto>.Failure(AppointmentErrors.NotFoundById);
        }

        var completeResult = appointment.Complete(command.BarberId);

        if (completeResult.IsFailure)
        {
            logger.LogInformation("Appointment complete failed for AppointmentId: {AppointmentId}", command.AppointmentId);

            return Result<AppointmentDto>.Failure(completeResult.Error);
        }

        appointmentRepository.Update(appointment);

        return Result<AppointmentDto>.Success(appointment.Adapt<AppointmentDto>());
    }
}
