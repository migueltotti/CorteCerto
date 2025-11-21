using CorteCerto.Application.Common;
using CorteCerto.Application.Extentions;
using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Filters;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace CorteCerto.Infrastructure.Repositories;

public class AppointmentRepository(CorteCertoDbContext context) : 
    BaseRepository<Appointment, Guid>(context),
    IAppointmentRepository
{
    public async Task<PagedResult<Appointment>> GetWithFilter(AppointmentFilter filter, List<string>? includes = null, CancellationToken token = default)
    {
        var query = context.Appointments
            .AsNoTracking()
            .AsQueryable();

        if (filter.AppointmentId is not null)
            query = query.Where(a => a.Id.Equals(filter.AppointmentId));

        if (filter.CustomerId is not null)
            query = query.Where(a => a.Customer.Id.Equals(filter.CustomerId));

        if (filter.BarberId is not null)
            query = query.Where(a => a.Barber.Id.Equals(filter.BarberId));

        if (filter.ServiceId is not null)
            query = query.Where(a => a.Service.Id.Equals(filter.ServiceId));

        if (!string.IsNullOrEmpty(filter.CustomerName))
            query = query.Where(a => a.Customer.Name.Contains(filter.CustomerName));

        if (!string.IsNullOrEmpty(filter.BarberName))
            query = query.Where(a => a.Barber.Name.Contains(filter.BarberName));

        if (!string.IsNullOrEmpty(filter.ServiceName))
            query = query.Where(a => a.Service.Name.Contains(filter.ServiceName));

        if (filter.AppointmentStatus is not null)
            query = query.Where(a => a.Status.Equals(filter.AppointmentStatus));

        if (filter.InitialDate is not null)
            query = query.Where(a => a.Date.Date >= filter.InitialDate.Value.Date);

        if (filter.FinalDate is not null)
            query = query.Where(a => a.Date <= filter.FinalDate.Value.Date);

        if (includes is not null)
        {
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
        }

        query = query.OrderBy(s => s.Date);

        var paginatedQuery = query
            .Skip((filter.PageNumber - 1) * filter.PageSize)
            .Take(filter.PageSize);

        var results = await paginatedQuery.ToListAsync();

        var totalCount = await GetPaginationTotalCount(query);

        return results.ToPagedResult(totalCount, filter.PageSize, filter.PageNumber);
    }

    private async Task<int> GetPaginationTotalCount(IQueryable<Appointment> query)
    {
        return await query.CountAsync();
    }
}
