using CorteCerto.Domain.Base;
using CorteCerto.Domain.Enums;
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
            return Result<Appointment>.Failure(new Error("InvalidDate", "The appointment date must be in the future"));

        if (customer.Id.Equals(barber.Id))
            return Result<Appointment>.Failure(new Error("InvalidAppointment", "Customer cannot be the same as the Barber"));

        if (!barber.Services.Contains(service))
            return Result<Appointment>.Failure(new Error("InvalidService", "The service must belong to the Barber"));

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
