using CorteCerto.Domain.Base;
using CorteCerto.Domain.Entities;
namespace CorteCerto.Domain.Interfaces.Repositories
{
    public interface IPersonRepository : IBaseRepository<Person>
    {
        Task<Person?> GetByEmailAsync(string email, CancellationToken cancellationToken = default);
    }
}
