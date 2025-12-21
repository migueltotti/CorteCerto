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
            logger.LogInformation("Invalid information for scheduling ServiceId: {ServiceId}, by BarberId: {BarberId} for CustomerId: {CustomerId}", command.Request.ServiceId, command.Request.BarberId, command.Request.CustomerId);

            return Result<AppointmentDto>.Failure(AppointmentErrors.ValidationError(JsonSerializer.Serialize(validationResult.Errors)));
        }

        if (command.Request.CustomerId.Equals(command.Request.BarberId))
        {
            logger.LogInformation("Barber and Customer are the same with Id {PersonId}", command.Request.CustomerId);

            return Result<AppointmentDto>.Failure(AppointmentErrors.InvalidAppointment);
        }
        
        var customer = await customerRepository.Select(command.Request.CustomerId, null, cancellationToken);

        if (customer is null)
        {
            logger.LogInformation("Customer not found with CustomerId: {CustomerId}", command.Request.CustomerId);

            return Result<AppointmentDto>.Failure(CustomerErrors.NotFoundById);
        }

        var barber = await barberRepository.Select(command.Request.BarberId, ["Services", "Availabilities", "Appointments", "Address.City.State.Country"], cancellationToken);

        if (barber is null)
        {
            logger.LogInformation("Barber not found with BarberId: {BarberId}", command.Request.BarberId);

            return Result<AppointmentDto>.Failure(BarberErrors.NotFoundById);
        }

        var service = barber.GetService(command.Request.ServiceId);

        if (service is null)
        {
            logger.LogInformation("Service with ServiceId: {ServiceId} not found for Barber with BarberId: {BarberId}", command.Request.ServiceId, command.Request.BarberId);

            return Result<AppointmentDto>.Failure(BarberErrors.ServiceNotFound);
        }

        var appointmentResult = Appointment.Create(
            command.Request.Date.ToUniversalTime(),
            TimeSpan.FromHours(2),
            customer,
            barber,
            service
        );

        if (appointmentResult.IsFailure)
        {
            logger.LogInformation("Failed to create Appointment for CustomerId: {CustomerId}, with ServiceId: {ServiceId} of BarberId: {BarberId} at Date {Date}", 
                command.Request.CustomerId, 
                command.Request.ServiceId, 
                command.Request.BarberId, 
                command.Request.Date.ToUniversalTime());

            return Result<AppointmentDto>.Failure(appointmentResult.Error);
        }

        appointmentRepository.Insert(appointmentResult.Data);

        logger.LogInformation("Appointment created successfully for CustomerId: {CustomerId}, with ServiceId: {ServiceId} of BarberId: {BarberId} at Date {Date}", 
            command.Request.CustomerId, 
            command.Request.ServiceId, 
            command.Request.BarberId, 
            command.Request.Date.ToUniversalTime());

        var appointmentResponse = appointmentResult.Data.Adapt<AppointmentDto>();

        return Result<AppointmentDto>.Success(appointmentResponse);
    }

}
