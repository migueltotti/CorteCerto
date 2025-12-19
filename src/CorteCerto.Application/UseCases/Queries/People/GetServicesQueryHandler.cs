using CorteCerto.Application.Common;
using CorteCerto.Application.DTO;
using CorteCerto.Application.Extentions;
using CorteCerto.Domain.Filters;
using CorteCerto.Domain.Interfaces.Repositories;
using LiteBus.Queries.Abstractions;
using Mapster;

namespace CorteCerto.Application.UseCases.Queries.People;

public class GetServicesQueryHandler(
    IServiceRepository serviceRepository)
    : IQueryHandler<GetServicesQuery, PagedResult<ServiceDto>>
{
    public async Task<PagedResult<ServiceDto>> HandleAsync(GetServicesQuery query, CancellationToken cancellationToken = default)
    {
        var filter = new ServiceFilter.Builder()
            .WithName(query.Request.Name)
            .WithPrice(query.Request.Price, query.Request.PriceOperator)
            .WithDuration(query.Request.Duration, query.Request.DurationOperator)
            .WithPagination(query.Request.PageSize, query.Request.PageNumber)
            .WithBarberId(query.Request.BarberId)
            .Build();

        var services = await serviceRepository.GetWithFilter(filter, ["Barber"], cancellationToken);

        var paginatedResponse = services.Results.Adapt<List<ServiceDto>>();

        return paginatedResponse.ToPagedResult(services.TotalCount, services.PageSize, services.PageNumber);
    }
}
