using CorteCerto.Application.Common;
using CorteCerto.Domain.Base;
using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Filters;

namespace CorteCerto.Domain.Interfaces.Repositories;

public interface IBarberRepository : IBaseRepository<Barber>
{
    Task<PagedResult<Barber>> GetWithFilter(PersonFilter filter, IList<string>? includes = null, CancellationToken token = default);
    Task<bool> EmailExistsAsync(string email);
    Task<Barber> RegisterBarber(Barber barber);
}
