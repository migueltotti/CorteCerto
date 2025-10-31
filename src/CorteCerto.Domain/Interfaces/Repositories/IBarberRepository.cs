using CorteCerto.Domain.Base;
using CorteCerto.Domain.Entities;

namespace CorteCerto.Domain.Interfaces.Repositories;

public interface IBarberRepository : IBaseRepository<Barber>
{
    Task<bool> EmailExistsAsync(string email);
}
