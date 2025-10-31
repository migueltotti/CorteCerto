using CorteCerto.Domain.Base;
using CorteCerto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Domain.Interfaces.Repositories;

public interface ICustomerRepository : IBaseRepository<Customer>
{
    Task<bool> EmailExistsAsync(string email);
}
