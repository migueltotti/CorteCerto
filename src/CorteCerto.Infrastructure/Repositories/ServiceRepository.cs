using CorteCerto.Application.Common;
using CorteCerto.Application.Extentions;
using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Filters;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace CorteCerto.Infrastructure.Repositories;

public class ServiceRepository(CorteCertoDbContext context) :
    BaseRepository<Service, int>(context),
    IServiceRepository
{
    public async Task<PagedResult<Service>> GetWithFilter(ServiceFilter filter, List<string>? includes = null, CancellationToken token = default)
    {
        var query = context.Services
            .AsNoTracking()
            .AsQueryable();

        if (filter.Ids is not null)
            query = query.Where(s => filter.Ids.Contains(s.Id));
        
        if (!string.IsNullOrEmpty(filter.Name))
            query = query.Where(s => s.Name.Contains(filter.Name));

        if (filter.Price is not null)
        {
            query = filter.PriceOperator switch
            {
                PriceOperator.Equal => query.Where(s => s.Price.Equals(filter.Price)),
                PriceOperator.GreaterThan => query.Where(s => s.Price > filter.Price),
                PriceOperator.LessThan => query.Where(s => s.Price < filter.Price),
                _ => query
            };
        }

        if (filter.Duration is not null)
        {
            query = filter.DurationOperator switch
            {
                DurationOperator.Equal => query.Where(s => s.Duration.Equals(filter.Duration)),
                DurationOperator.GreaterThan => query.Where(s => s.Duration > filter.Duration),
                DurationOperator.LessThan => query.Where(s => s.Duration < filter.Duration),
                _ => query
            };
        }

        if (includes is not null)
        {
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
        }

        query = query.OrderBy(s => s.Name);

        var paginatedQuery = query
            .Skip((filter.PageNumber - 1) * filter.PageSize)
            .Take(filter.PageSize);

        var results = await paginatedQuery.ToListAsync();

        var totalCount = await GetPaginationTotalCount(query);

        return results.ToPagedResult(totalCount, filter.PageSize, filter.PageNumber);
    }

    private async Task<int> GetPaginationTotalCount(IQueryable<Service> query)
    {
        return await query.CountAsync();
    }
}
