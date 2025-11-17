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
            .WithId(query.Id)
            .WithName(query.Name)
            .WithEmail(query.Email)
            .WithPagination(query.PageSize, query.PageNumber)
            .Build();

        var barbers = await barberRepository.GetWithFilter(filter, token: cancellationToken);

        var barbersResponse = barbers.Results.Adapt<List<BarberDto>>();

        return barbersResponse.ToPagedResult(barbers.PageSize, barbers.PageNumber);
    }
}