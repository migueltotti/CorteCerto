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
    Task<IEnumerable<Customer>> GetWithFilter(PersonFilter filter);
    Task<bool> EmailExistsAsync(string email);
}
