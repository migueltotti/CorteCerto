using CorteCerto.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Domain.Entities;

public class Address : BaseEntity<Guid>
{
    public string Street { get; private set; }
    public string Neighborhood { get; private set; }
    public int Number { get; private set; }
    public string ZipCode { get; private set; }
    public City City { get; private set; }


    public Address(string street, int number, string neighborhood, string zipCode, City city)
    {
        Street = street;
        Number = number;
        ZipCode = zipCode;
        City = city;
        Neighborhood = neighborhood;
    }

    private Address() { }
}
