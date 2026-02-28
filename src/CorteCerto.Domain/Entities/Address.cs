using CorteCerto.Domain.Base;

namespace CorteCerto.Domain.Entities;

public class Address : BaseEntity<Guid>
{
    public string Street { get; private set; }
    public string Neighborhood { get; private set; }
    public int Number { get; private set; }
    public string ZipCode { get; private set; }
    public int CityId { get; private set; }
    public City? City { get; private set; }


    public Address(string street, int number, string neighborhood, string zipCode, int cityId) : base(Guid.NewGuid())
    {
        Street = street;
        Number = number;
        ZipCode = zipCode;
        CityId = cityId;
        Neighborhood = neighborhood;
    }

    private Address()
    {
    }
}