using CorteCerto.Application.Common;
using CorteCerto.Application.Extentions;
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
    public async Task<PagedResult<Customer>> GetWithFilter(PersonFilter filter, IList<string>? includes = null, CancellationToken token = default)
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

        query = query.OrderBy(c => c.Name);

        if (includes is not null)
        {
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
        }

        query = query
           .Skip((filter.PageNumber - 1) * filter.PageSize)
           .Take(filter.PageSize);

        var results = await query.ToListAsync();

        return results.ToPagedResult(filter.PageSize, filter.PageNumber);
    }

    public async Task<bool> EmailExistsAsync(string email)
    {
        return await context.People.AnyAsync(c => c.Email == email);
    }
}
