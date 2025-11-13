using CorteCerto.Domain.Base;
using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Filters;

namespace CorteCerto.Domain.Interfaces.Repositories;

public interface IBarberRepository : IBaseRepository<Barber>
{
    Task<IEnumerable<Barber>> GetWithFilter(PersonFilter filter);
    Task<bool> EmailExistsAsync(string email);
    Task<Barber> RegisterBarber(Barber barber);
}
