using System.Text.Json.Serialization;
using CorteCerto.Domain.Filters;

namespace CorteCerto.Application.Requests;

public record GetServicesRequest(
    IEnumerable<int>? Ids = null,
    string? Name = null,
    TimeSpan? Duration = null,
    decimal? Price = null,
    PriceOperator PriceOperator = default,
    DurationOperator DurationOperator = default,
    Guid? BarberId = null,
    int PageSize = 50,
    int PageNumber = 1    
);