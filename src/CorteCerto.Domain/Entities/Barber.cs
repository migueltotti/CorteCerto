
using CorteCerto.Domain.Base;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.ValueObjects;
using System.Threading;
using CorteCerto.Domain.Enums;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CorteCerto.Domain.Entities;

public class Barber : Person
{
    public string Description { get; private set; }
    public string PortfolioUrl { get; private set; }
    public float Rating { get; private set; }
    public Address Address { get; private set; }
    public List<BarberAvailability> Availabilities { get; private set; } = [];
    public List<Service> Services { get; private set; } = [];
    public List<Appointment> Appointments { get; private set; } = [];
        
    private Barber()
    {
    }

    public Barber(Guid id, string name, string email, string phoneNumber, string password, string description, string portfolioUrl, Address address) : base(id, name, email, phoneNumber, password)
    {
        Description = description;
        PortfolioUrl = portfolioUrl;
        Address = address;
        Rating = 0;
        Availabilities = [];
        Appointments = [];
        Services = [];
    }

    public Barber SetName(string name)
    {
        Name = name;
        return this;
    }

    public Barber SetEmail(string email)
    {
        Email = email;
        return this;
    }

    public Barber SetPasswordHash(string passwordHash)
    {
        PasswordHash = passwordHash;
        return this;
    }

    public Barber SetPhoneNumber(string phoneNumber)
    {
        PhoneNumber = phoneNumber;
        return this;
    }

    public Barber SetDescription(string description)
    {
        Description = description;
        return this;
    }

    public Barber SetPortifolioUrl(string portifolioUrl)
    {
        PortfolioUrl = portifolioUrl;
        return this;
    }

    public Barber SetAddress(Address address)
    {
        Address = address;
        return this;
    }

    public Service? GetService(int serviceId)
    {
        return Services.FirstOrDefault(s => s.Id.Equals(serviceId));
    }

    public void AddService(Service service)
    {
        Services.Add(service);
    }

    public void UpdateService(Service service)
    {
        Services.RemoveAll(s => s.Id == service.Id);

        Services.Add(service);
    }

    public void RemoveService(int serviceId)
    {
        Services.RemoveAll(s => s.Id == serviceId);
    }

    public BarberAvailability? GetAvailabilityAt(DayOfWeek dayOfWeek)
    {
        return Availabilities.FirstOrDefault(a => a.DayOfWeek == dayOfWeek);
    }

    public void UpsertAvailability(BarberAvailability availability)
    {
        var existingAvailability = Availabilities.FirstOrDefault(a => a.DayOfWeek == availability.DayOfWeek);

        if (existingAvailability is not null)
        {
            existingAvailability.SetStartTime(availability.StartTime);
            existingAvailability.SetEndTime(availability.EndTime);
        }
        else
        {
            Availabilities.Add(availability);
        }
    }

    public bool HasAppointmentAtTime(DateTime dateTime)
    {
        return Appointments.Exists(ap => ap.Date.Equals(dateTime));
    }

    public bool HasAppointmentEndTimeCollision(DateTime startTime, DateTime endDateTime)
    {
        return Appointments.Exists(ap => 
            ap.Date.DayOfWeek.Equals(endDateTime.DayOfWeek) &&
            startTime < ap.Date &&
            ap.Date.Add(ap.Service.Duration) <= endDateTime &&
            ap.Status is not AppointmentStatus.Completed and AppointmentStatus.Canceled);
    }
}
