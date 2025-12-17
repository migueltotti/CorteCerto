using CorteCerto.Application.Common;
using CorteCerto.Application.DTO;
using CorteCerto.Application.Extentions;
using CorteCerto.Domain.Filters;
using CorteCerto.Domain.Interfaces.Repositories;
using LiteBus.Queries.Abstractions;
using Mapster;

namespace CorteCerto.Application.UseCases.Queries.Barbers;

public class GetBarbersQueryHandler(
    IBarberRepository barberRepository)
    : IQueryHandler<GetBarbersQuery, PagedResult<BarberDto>>
{
    public async Task<PagedResult<BarberDto>> HandleAsync(GetBarbersQuery query, CancellationToken cancellationToken = default)
    {
        var filter = new PersonFilter.Builder()
            .WithIds(query.Request.Ids)
            .WithName(query.Request.Name)
            .WithEmail(query.Request.Email)
            .WithPagination(query.Request.PageSize, query.Request.PageNumber)
            .Build();

        var barbers = await barberRepository.GetWithFilter(filter, ["Address.City.State.Country"], token: cancellationToken);

        var barbersResponse = barbers.Results.Adapt<List<BarberDto>>();

        return barbersResponse.ToPagedResult(barbers.TotalCount, barbers.PageSize, barbers.PageNumber);
    }
}