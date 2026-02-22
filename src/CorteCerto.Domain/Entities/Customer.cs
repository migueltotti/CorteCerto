using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Domain.Entities;

public class Customer : Person
{
    public int PromotionPoints { get; private set; }
    public List<Appointment> Appointments { get; private set; }

    private Customer()
    {
    }

    public Customer(Guid id, string name, string email, string phoneNumber, string passwordHash) 
        : base(id, name, email, phoneNumber, passwordHash)
    {
        PromotionPoints = 0;
        Appointments = [];
    }

    public void AccruePointsFromService(decimal serviceAmount)
    {
        if (serviceAmount >= 0)
            PromotionPoints += (int)serviceAmount;
    }
}
