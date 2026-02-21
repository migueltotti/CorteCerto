namespace CorteCerto.Application.Interfaces;

public interface IAppointmentExpirationJob
{
    Task HandleApprovalExpirationAsync(Guid appointmentId, DateTime registrationTimeInUtc);
}