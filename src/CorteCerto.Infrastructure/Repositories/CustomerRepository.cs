using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Interfaces;
using CorteCerto.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Infrastructure.Repositories;

public class CustomerRepository(CorteCertoDbContext context) : 
    BaseRepository<Customer, Guid>(context), 
    ICustomerRepository
{
}
