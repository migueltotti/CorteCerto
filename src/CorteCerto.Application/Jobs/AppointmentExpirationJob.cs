using CorteCerto.Application.Interfaces;
using CorteCerto.Domain.Constants;
using CorteCerto.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Logging;

namespace CorteCerto.Application.Jobs;

public class AppointmentExpirationJob(
    IAppointmentRepository appointmentRepository,
    IEmailService emailService,
    ILogger<AppointmentExpirationJob> logger) : IAppointmentExpirationJob
{
    public async Task HandleApprovalExpirationAsync(Guid appointmentId, DateTime registrationTimeInUtc)
    {
        var appointment = await appointmentRepository.Select(appointmentId, ["Barber", "Customer", "Service"]);

        if (appointment is null)
        {
            logger.LogWarning("Hangfire - HandleApprovalExpirationAsync - Appointment not found for id: {Id}", appointmentId);
            return;
        }

        var expired = appointment.ExpireIfNotApproved(registrationTimeInUtc);
        
        appointmentRepository.Update(appointment);

        if (expired)
        {
            await emailService.SendCustomerAppointmentCanceledNotificationAsync(
                appointment,
                CorteCertoConstants.AppointmentCancellationByResponseDeadlineExcided,
                CancellationToken.None);
        }
        
        logger.LogInformation("Hangfire - HandleApprovalExpirationAsync - Appointment {Id} canceled successfully by approval expiration deadline.", appointmentId);
    }
}