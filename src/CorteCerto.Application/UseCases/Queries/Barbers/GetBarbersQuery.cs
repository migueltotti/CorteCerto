
using CorteCerto.Application.Common;
using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using LiteBus.Queries.Abstractions;

namespace CorteCerto.Application.UseCases.Queries.Barbers;

public record GetBarbersQuery(
    Guid? Id,
    string? Name,
    string? Email,
    int PageSize = 50,
    int PageNumber = 1
) : IQuery<PagedResult<BarberDto>>;
