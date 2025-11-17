using CorteCerto.Application.Common;
using CorteCerto.Domain.Base;
using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Domain.Interfaces.Repositories;

public interface ICustomerRepository : IBaseRepository<Customer>
{
    Task<PagedResult<Customer>> GetWithFilter(PersonFilter filter, IList<string>? includes = null, CancellationToken token = default);
    Task<bool> EmailExistsAsync(string email);
}
