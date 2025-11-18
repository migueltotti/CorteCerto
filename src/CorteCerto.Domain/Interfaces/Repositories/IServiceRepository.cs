using CorteCerto.Application.Common;
using CorteCerto.Domain.Base;
using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Filters;

namespace CorteCerto.Domain.Interfaces.Repositories;

public interface IServiceRepository : IBaseRepository<Service>
{
    Task<PagedResult<Service>> GetWithFilter(ServiceFilter filter, List<string>? includes = null, CancellationToken token = default);
}
