using CorteCerto.Application.Common;
using CorteCerto.Application.DTO;
using LiteBus.Queries.Abstractions;

namespace CorteCerto.Application.UseCases.Queries.Customers;

public record GetCustomersQuery(
    Guid? Id,
    string? Name,
    string? Email,
    int PageSize = 50,
    int PageNumber = 1
) : IQuery<PagedList<CustomerDto>>;
