using CorteCerto.Application.Interfaces;
using CorteCerto.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Logging;

namespace CorteCerto.Application.Jobs;

public class AppointmentExpirationJob(
    IAppointmentRepository appointmentRepository,
    ILogger<AppointmentExpirationJob> logger) : IAppointmentExpirationJob
{
    public async Task HandleApprovalExpirationAsync(Guid appointmentId)
    {
        var appointment = await appointmentRepository.Select(appointmentId);

        if (appointment is null)
        {
            logger.LogWarning("Hangfire - HandleApprovalExpirationAsync - Appointment not found for id: {Id}", appointmentId);
            return;
        }

        appointment.ExpireIfNotApproved();
        
        appointmentRepository.Update(appointment);
        
        logger.LogInformation("Hangfire - HandleApprovalExpirationAsync - Appointment {Id} canceled successfully by approval expiration deadline.", appointmentId);
    }
}