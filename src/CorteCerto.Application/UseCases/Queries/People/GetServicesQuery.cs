using CorteCerto.Application.Common;
using CorteCerto.Application.DTO;
using CorteCerto.Domain.Filters;
using LiteBus.Queries.Abstractions;
namespace CorteCerto.Application.UseCases.Queries.People;

public record GetServicesQuery(
    string? Name = null,
    TimeSpan? Duration = null,
    decimal? Price = null,
    PriceOperator PriceOperator = default,
    DurationOperator DurationOperator = default,
    int PageSize = 50,
    int PageNumber = 1
) : IQuery<PagedResult<ServiceDto>>;
