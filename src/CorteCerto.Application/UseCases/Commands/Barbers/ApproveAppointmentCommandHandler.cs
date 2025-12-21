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

public class ApproveAppointmentCommandHandler(
    IAppointmentRepository appointmentRepository,
    IValidator<ApproveAppointmentCommand> validator,
    ILogger<ApproveAppointmentCommandHandler> logger): ICommandHandler<ApproveAppointmentCommand, Result<AppointmentDto>>
{
    public async Task<Result<AppointmentDto>> HandleAsync(ApproveAppointmentCommand command, CancellationToken cancellationToken = default)
    {
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
        {
            logger.LogInformation("Appointment approve validation failed for AppointmentId: {AppointmentId}", command.AppointmentId);

            return Result<AppointmentDto>.Failure(AppointmentErrors.ValidationError(JsonSerializer.Serialize(validationResult.Errors)));
        }

        var appointment = await appointmentRepository.Select(command.AppointmentId, ["Barber"], cancellationToken);

        if (appointment is null)
        {
            logger.LogInformation("Appointment not found with AppointmentId: {AppointmentId}", command.AppointmentId);

            return Result<AppointmentDto>.Failure(AppointmentErrors.NotFoundById);
        }

        var approvementResult = appointment.Approve(command.Request.BarberId);

        if (approvementResult.IsFailure)
        {
            logger.LogInformation("Appointment approve failed for AppointmentId: {AppointmentId}", command.AppointmentId);

            return Result<AppointmentDto>.Failure(approvementResult.Error);
        }

        appointmentRepository.Update(appointment);

        return Result<AppointmentDto>.Success(appointment.Adapt<AppointmentDto>());
    }
}
