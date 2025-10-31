using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
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
    public async Task<bool> EmailExistsAsync(string email)
    {
        return await context.People.AnyAsync(c => c.Email == email);
    }
}
