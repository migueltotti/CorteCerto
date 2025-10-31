using CorteCerto.Domain.Base;
using CorteCerto.Domain.Entities;

namespace CorteCerto.Domain.Interfaces.Repositories;

public interface ICountryRepository : IBaseRepository<Country>
{
    Task<Country?> GetCountryByName(string name);
}
