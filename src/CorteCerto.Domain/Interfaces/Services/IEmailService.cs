using CorteCerto.Domain.Base;
using CorteCerto.Domain.Entities;

namespace CorteCerto.Domain.Interfaces.Services;

public interface IEmailService
{
    Task SendUserEmailConfirmationAsync(Customer customer, CancellationToken cancellationToken);
    Task SendCustomerAppointmentRegisteredNotificationAsync(Appointment appointment, CancellationToken cancellationToken);
    Task SendCustomerAppointmentScheduledNotificationAsync(Appointment appointment, CancellationToken cancellationToken);
    Task SendCustomerAppointmentCompletedNotificationAsync(Appointment appointment, CancellationToken cancellationToken);
    Task SendCustomerAppointmentCanceledNotificationAsync(Appointment appointment, CancellationToken cancellationToken);
}