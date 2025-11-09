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
    public List<Appointment> Appointments{ get; private set; }
        

    private Service()
    {
    }

    internal Service(string name, string description, decimal price, TimeSpan duration, bool isAvailable, Barber barber)
    {
        Name = name;
        Description = description;
        Price = price;
        Duration = duration;
        IsAvailable = isAvailable;
        Barber = barber;
        Appointments = [];
    }
}
