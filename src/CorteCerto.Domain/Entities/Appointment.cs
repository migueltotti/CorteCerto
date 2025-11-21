using CorteCerto.Domain.Base;
using CorteCerto.Domain.Enums;
using CorteCerto.Domain.Errors;

namespace CorteCerto.Domain.Entities;

public class Appointment : BaseEntity<Guid>
{
    public DateTime Date { get; private set; }
    public AppointmentStatus Status { get; private set; }
    public TimeSpan ResponseDeadline { get; private set; }
    public Customer Customer { get; private set; }
    public Barber Barber { get; private set; }
    public Service Service { get; private set; }
    
    private Appointment()
    {
    }

    private Appointment(Guid id, DateTime date, TimeSpan responseDeadline, Customer customer, Barber barber, Service service) : base(id)
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
        if (date <= DateTime.Now)
            return Result<Appointment>.Failure(AppointmentErrors.InvalidDate);

        var availabilityForDate = barber.GetAvailabilityAt(date.DayOfWeek);

        if (availabilityForDate is null)
            return Result<Appointment>.Failure(BarberErrors.NotAvailableAtDate);

        if (availabilityForDate.StartTime.TimeOfDay > date.TimeOfDay)
            return Result<Appointment>.Failure(BarberErrors.NotAvailableStartTime);

        if (barber.HasAppointmentAtTime(date))
            return Result<Appointment>.Failure(AppointmentErrors.AppointmentExistsAtTime);

        if (availabilityForDate.EndTime.TimeOfDay < date.Add(service.Duration).TimeOfDay)
            return Result<Appointment>.Failure(BarberErrors.NotAvailableAtTime);

        if (barber.HasAppointmentEndTimeCollision(date, service.Duration))
            return Result<Appointment>.Failure(AppointmentErrors.EndTimeCollision);

        return Result<Appointment>.Success(new Appointment(
            Guid.NewGuid(), 
            date,
            responseDeadline, 
            customer, 
            barber, 
            service
        ));
    }

    public Result Aprove(Guid barberId)
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

    public Result Cancelate(Guid barberId, Guid customerId)
    {
        if (!barberId.Equals(Barber.Id))
            return Result.Failure(AppointmentErrors.BarberIdMismatch);

        if (!customerId.Equals(Customer.Id))
            return Result.Failure(AppointmentErrors.CustomerIdMismatch);

        if (Status is AppointmentStatus.Completed)
            return Result.Failure(AppointmentErrors.CancelationFailed);

        Status = AppointmentStatus.Canceled;

        return Result.Success();
    }
}
