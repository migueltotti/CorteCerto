using CorteCerto.Domain.Base;
using CorteCerto.Domain.Enums;
using CorteCerto.Domain.Errors;

namespace CorteCerto.Domain.Entities;

public class Appointment : BaseEntity<Guid>
{
    public DateTime Date { get; private set; }
    public AppointmentStatus Status { get; private set; }
    public TimeSpan ResponseDeadline { get; private set; }
    public Customer? Customer { get; private set; }
    public Barber Barber { get; private set; }
    public Service Service { get; private set; }
    
    private Appointment()
    {
    }

    private Appointment(Guid id, DateTime date, TimeSpan responseDeadline, Customer? customer, Barber barber, Service service) : base(id)
    {
        Date = date;
        Status = AppointmentStatus.WaitingForAprovement;
        ResponseDeadline = responseDeadline;
        Customer = customer;
        Barber = barber;
        Service = service;
    }

    public static Result<Appointment> Create(DateTime date, TimeSpan responseDeadline, Customer customer, Barber barber, Service service)
    {
        var appointmentStartTimeUtc = date.ToUniversalTime();
        var appointmentEndTimeUtc = date.Add(service.Duration).ToUniversalTime();
        
        if (appointmentStartTimeUtc <= DateTime.UtcNow)
            return Result<Appointment>.Failure(AppointmentErrors.InvalidDate);

        var availabilityForDate = barber.GetAvailabilityAt(appointmentStartTimeUtc.DayOfWeek);

        if (availabilityForDate is null)
            return Result<Appointment>.Failure(BarberErrors.NotAvailableAtDate);

        var (availabilityStartTime, availabilityEndTime) =
            availabilityForDate.GetTimeAvailabilityFormatedForAppointmentDate(appointmentStartTimeUtc);

        if (availabilityStartTime > appointmentStartTimeUtc)
            return Result<Appointment>.Failure(BarberErrors.NotAvailableStartTime);

        if (barber.HasAppointmentAtTime(appointmentStartTimeUtc))
            return Result<Appointment>.Failure(AppointmentErrors.AppointmentExistsAtTime);

        if (availabilityEndTime < appointmentEndTimeUtc)
            return Result<Appointment>.Failure(BarberErrors.NotAvailableAtTime);
        
        if (barber.HasAppointmentEndTimeCollision(appointmentStartTimeUtc, appointmentEndTimeUtc))
            return Result<Appointment>.Failure(AppointmentErrors.EndTimeCollision);

        return Result<Appointment>.Success(new Appointment(
            Guid.NewGuid(), 
            appointmentStartTimeUtc,
            responseDeadline, 
            customer, 
            barber, 
            service
        ));
    }

    public Result Approve(Guid barberId)
    {
        if (!barberId.Equals(Barber.Id))
            return Result.Failure(AppointmentErrors.BarberIdMismatch);

        if (Status is not AppointmentStatus.WaitingForAprovement)
            return Result.Failure(AppointmentErrors.AprovementFailed);

        Status = AppointmentStatus.Scheduled;

        return Result.Success();
    }

    public Result Complete(Guid barberId)
    {
        if (!barberId.Equals(Barber.Id))
            return Result.Failure(AppointmentErrors.BarberIdMismatch);

        if (Status is not AppointmentStatus.Scheduled)
            return Result.Failure(AppointmentErrors.CompleteFailed);

        Status = AppointmentStatus.Completed;

        return Result.Success();
    }

    public Result Cancel(Guid barberId, Guid customerId)
    {
        if (!barberId.Equals(Barber.Id))
            return Result.Failure(AppointmentErrors.BarberIdMismatch);

        if (!customerId.Equals(Customer?.Id ?? Guid.Empty))
            return Result.Failure(AppointmentErrors.CustomerIdMismatch);

        if (Status is AppointmentStatus.Completed)
            return Result.Failure(AppointmentErrors.CancelationFailed);

        Status = AppointmentStatus.Canceled;

        return Result.Success();
    }

    public bool ExpireIfNotApproved(DateTime registrationTimeInUtc)
    {
        if (Status is AppointmentStatus.WaitingForAprovement && 
            DateTime.UtcNow >= registrationTimeInUtc.Add(ResponseDeadline))
        {
            Status = AppointmentStatus.Canceled;
            return true;
        }

        return false;
    }
}
