using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.Interfaces.Repositories;
using FluentValidation;
using LiteBus.Commands.Abstractions;
using Mapster;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CorteCerto.Application.UseCases.Commands.Customers;

public class ScheduleBarberServiceCommandHandler(
    IBarberRepository barberRepository,
    ICustomerRepository customerRepository,
    IAppointmentRepository appointmentRepository,
    IValidator<ScheduleBarberServiceCommand> validator,
    ILogger<ScheduleBarberServiceCommandHandler> logger)
    : ICommandHandler<ScheduleBarberServiceCommand, Result<AppointmentDto>>
{
    public async Task<Result<AppointmentDto>> HandleAsync(ScheduleBarberServiceCommand command, CancellationToken cancellationToken = default)
    {
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
        {
            logger.LogInformation("Invalid informations for scheduling ServiceId: {ServiceId}, by BarberId: {BarberId} for CustomerId: {CustomerId}", command.ServiceId, command.BarberId, command.CustomerId);

            return Result<AppointmentDto>.Failure(AppointmentErrors.ValidationError(JsonSerializer.Serialize(validationResult.Errors)));
        }

        if (command.CustomerId.Equals(command.BarberId))
        {
            logger.LogInformation("Barber and Customer are the same with Id {PersonId}", command.CustomerId);

            return Result<AppointmentDto>.Failure(AppointmentErrors.InvalidAppointment);
        }
        
        var customer = await customerRepository.Select(command.CustomerId, null, cancellationToken);

        if (customer is null)
        {
            logger.LogInformation("Customer not found with CustomerId: {CustomerId}", command.CustomerId);

            return Result<AppointmentDto>.Failure(CustomerErrors.NotFoundById);
        }

        var barber = await barberRepository.Select(command.BarberId, ["Services", "Availabilities", "Appointments"], cancellationToken);

        if (barber is null)
        {
            logger.LogInformation("Barber not found with BarberId: {BarberId}", command.BarberId);

            return Result<AppointmentDto>.Failure(BarberErrors.NotFoundById);
        }

        var service = barber.GetService(command.ServiceId);

        if (service is null)
        {
            logger.LogInformation("Service with ServiceId: {ServiceId} not found for Barber with BarberId: {BarberId}", command.ServiceId, command.BarberId);

            return Result<AppointmentDto>.Failure(BarberErrors.ServiceNotFound);
        }

        var appointmentResult = Appointment.Create(
            command.Date,
            TimeSpan.FromHours(2),
            customer,
            barber,
            service
        );

        if (appointmentResult.IsFailure)
        {
            logger.LogInformation("Failed to create Appointment for CustomerId: {CustomerId}, with ServiceId: {ServiceId} of BarberId: {BarberId} at Date {Date}", command.CustomerId, command.ServiceId, command.BarberId, command.Date);

            return Result<AppointmentDto>.Failure(appointmentResult.Error);
        }

        appointmentRepository.Insert(appointmentResult.Data);

        logger.LogInformation("Appointment created successfully for CustomerId: {CustomerId}, with ServiceId: {ServiceId} of BarberId: {BarberId} at Date {Date}", command.CustomerId, command.ServiceId, command.BarberId, command.Date);

        var appointmentResponse = appointmentResult.Data.Adapt<AppointmentDto>();

        return Result<AppointmentDto>.Success(appointmentResponse);
    }

}
