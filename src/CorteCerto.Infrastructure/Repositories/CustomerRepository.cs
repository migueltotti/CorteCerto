using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Filters;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CorteCerto.Infrastructure.Repositories;

public class CustomerRepository(CorteCertoDbContext context) :
    BaseRepository<Customer, Guid>(context),
    ICustomerRepository
{
    public async Task<IEnumerable<Customer>> GetWithFilter(PersonFilter filter)
    {
        var query = context.Customers
            .AsQueryable()
            .AsNoTracking();

        if (filter.Id is not null)
            query = query.Where(c => c.Id == filter.Id);

        if (filter.Name is not null && filter.Name != String.Empty)
            query = query.Where(c => c.Name.Contains(filter.Name));

        if (filter.Email is not null && filter.Email != String.Empty)
            query = query.Where(c => c.Email == filter.Email);

        return await query.ToListAsync();
    }

    public async Task<bool> EmailExistsAsync(string email)
    {
        return await context.People.AnyAsync(c => c.Email == email);
    }
}
