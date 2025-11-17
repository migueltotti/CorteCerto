using CorteCerto.Domain.Base;
using CorteCerto.Domain.Errors;

namespace CorteCerto.Domain.Entities;

public class Service : BaseEntity<int>
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public TimeSpan Duration { get; private set; }
    public bool IsAvailable { get; private set; }   
    public Barber Barber { get; private set; }
    public List<Appointment> Appointments { get; private set; } = [];
        

    private Service()
    {
    }

    private Service(string name, string description, decimal price, TimeSpan duration, bool isAvailable)
    {
        Name = name;
        Description = description;
        Price = price;
        Duration = duration;
        IsAvailable = isAvailable;
        Appointments = [];
    }

    public static Result<Service> Create(string name, string description, decimal price, TimeSpan duration)
    {
        if (duration.TotalMinutes < 15 || duration.TotalDays > 1)
            return Result<Service>.Failure(ServiceErrors.DurationInvalid);

        return Result<Service>.Success(new Service(
            name,
            description,
            price,
            duration,
            true
        ));
    }

    public Result Update(string name, string description, decimal price, TimeSpan duration, bool isAvailable)
    {
        if (duration.TotalMinutes < 15 || duration.TotalDays > 1)
            return Result<Service>.Failure(ServiceErrors.DurationInvalid);

        Name = name;
        Description = description;
        Price = price;
        Duration = duration;
        IsAvailable = isAvailable;

        return Result.Success();
    }
}
