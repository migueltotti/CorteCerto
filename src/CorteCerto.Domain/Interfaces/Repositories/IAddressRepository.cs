using CorteCerto.Domain.Base;
using CorteCerto.Domain.Entities;

namespace CorteCerto.Domain.Interfaces.Repositories;

public interface IAddressRepository : IBaseRepository<Address>
{
    Task<Address?> GetAddressWithCityByZipCode(string zipCode);
}
