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

        if (filter.Ids is not null)
            query = query.Where(c => filter.Ids.Contains(c.Id));

        if (filter.Name is not null && filter.Name != string.Empty)
            query = query.Where(c => c.Name.Contains(filter.Name));

        if (filter.Email is not null && filter.Email != string.Empty)
            query = query.Where(c => c.Email == filter.Email);

        query = query.OrderBy(c => c.Name);

        if (includes is not null)
        {
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
        }

        var paginatedQuery = query
            .Skip((filter.PageNumber - 1) * filter.PageSize)
            .Take(filter.PageSize);

        var results = await paginatedQuery.ToListAsync(token);

        var totalCount = await GetPaginationTotalCount(query);

        return results.ToPagedResult(totalCount, filter.PageSize, filter.PageNumber);
    }

    private async Task<int> GetPaginationTotalCount(IQueryable<Customer> query)
    {
        return await query.CountAsync();
    }

    public async Task<bool> EmailExistsAsync(string email)
    {
        return await context.People.AnyAsync(c => c.Email == email);
    }
}
