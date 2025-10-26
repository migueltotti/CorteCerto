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

    public Service(int id, string name, string description, decimal price, TimeSpan duration, Barber barber) : base(id)
    {
        Name = name;
        Description = description;
        Price = price;
        Duration = duration;
        Barber = barber;
        Appointments = [];
    }
}
