using CorteCerto.Domain.Base;
using CorteCerto.Domain.Enums;
using CorteCerto.Domain.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
