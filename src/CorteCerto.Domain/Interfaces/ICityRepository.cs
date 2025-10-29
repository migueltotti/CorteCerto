using CorteCerto.Domain.Base;
using CorteCerto.Domain.Entities;

namespace CorteCerto.Domain.Interfaces;

public interface ICityRepository : IBaseRepository<City>
{
    Task<City?> GetCityByNameAndStateAcronym(string cityName, string stateAcronym); 
}
