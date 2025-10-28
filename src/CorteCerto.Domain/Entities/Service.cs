using CorteCerto.Domain.Base;

namespace CorteCerto.Domain.Entities;

public class Service : BaseEntity<int>
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public TimeSpan Duration { get; private set; }
    public Barber Barber { get; private set; }
    public List<Appointment> Appointments{ get; private set; }
        

    private Service()
    {
    }

    private Service(string name, string description, decimal price, TimeSpan duration, Barber barber)
    {
        Name = name;
        Description = description;
        Price = price;
        Duration = duration;
        Barber = barber;
        Appointments = [];
    }

    public static Result<Service> Create(string name, string description, decimal price, TimeSpan duration, Barber barber)
    {   
        if (duration.TotalMinutes < 15 && duration.TotalDays <= 1)
            return Result<Service>.Failure(new Error("InvalidDuration", "The service duration must be at least 15 minutes and maximum of 1 day"));
        
        return Result<Service>.Success(new Service(
            name,
            description,
            price,
            duration,
            barber
        ));
    }
}
