using CorteCerto.Application.Common;
using CorteCerto.Application.Extentions;
using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Filters;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CorteCerto.Infrastructure.Repositories;

public class BarberRepository(CorteCertoDbContext context) : 
    BaseRepository<Barber, Guid>(context), 
    IBarberRepository
{
    public async Task<PagedResult<Barber>> GetWithFilter(PersonFilter filter, IList<string>? includes = null, CancellationToken token = default)
    {
        var query = context.Barbers
            .AsQueryable()
            .AsNoTracking();

        if (filter.Ids is not null)
            query = query.Where(b => filter.Ids.Contains(b.Id));

        if (filter.Name is not null && filter.Name != string.Empty)
            query = query.Where(b => b.Name.Contains(filter.Name));

        if (filter.Email is not null && filter.Email != string.Empty)
            query = query.Where(b => b.Email == filter.Email);

        query = query.OrderBy(b => b.Name);

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

    private async Task<int> GetPaginationTotalCount(IQueryable<Barber> query)
    {
        return await query.CountAsync();
    }

    public async Task<bool> EmailExistsAsync(string email)
    {
        return await context.People.AnyAsync(c => c.Email == email);
    }

    public async Task<Barber> RegisterBarber(Barber barber)
    {
        var result = await context.Database.ExecuteSqlInterpolatedAsync(
            $@"
            INSERT INTO public.""Barbers""(
                ""Id"",
                ""Description"",
                ""PortfolioUrl"",
                ""Rating"",
                ""AddressId"")
            VALUES(
                {barber.Id},
                {barber.Description},
                {barber.PortfolioUrl},
                {barber.Rating},
                {barber.Address.Id});"
        );

        if(result == 0)
            throw new Exception("Failed to register barber.");

        return barber;
    }
}
