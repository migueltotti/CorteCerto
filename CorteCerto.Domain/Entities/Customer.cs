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

    public Customer(Guid id, string name, string email, string phoneNumber, string password, int promotionPoints) : base(id, name, email, phoneNumber, password)
    {
        PromotionPoints = promotionPoints;
        Appointments = [];
    }
}
