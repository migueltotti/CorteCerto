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
    : IQueryHandler<GetBarbersQuery, PagedList<BarberDto>>
{
    public async Task<PagedList<BarberDto>> HandleAsync(GetBarbersQuery query, CancellationToken cancellationToken = default)
    {
        var filter = new PersonFilter.Builder()
            .WithId(query.Id)
            .WithName(query.Name)
            .WithEmail(query.Email)
            .Build();

        var barbers = await barberRepository.GetWithFilter(filter);

        var barbersResponse = barbers.Adapt<List<BarberDto>>();

        return barbersResponse.ToPagedList(query.PageNumber, query.PageSize);
    }
}