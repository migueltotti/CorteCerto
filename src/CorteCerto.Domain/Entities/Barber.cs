using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Domain.Entities;

public class Barber : Person
{
    public string Description { get; private set; }
    public string PortfolioUrl { get; private set; }
    public float Rating { get; private set; }
    public Address Address { get; private set; }
    public List<BarberAvailability> Availabilities { get; private set; }
    public List<Service> Services { get; private set; }
    public List<Appointment> Appointments { get; private set; }
        
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
}
