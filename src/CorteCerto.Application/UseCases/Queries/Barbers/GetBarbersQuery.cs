using CorteCerto.Application.Common;
using CorteCerto.Application.DTO;
using LiteBus.Queries.Abstractions;

namespace CorteCerto.Application.UseCases.Queries.Barbers;

public record GetBarbersQuery(
    Guid? Id = null,
    string? Name = null,
    string? Email = null,
    int PageSize = 50,
    int PageNumber = 1
) : IQuery<PagedResult<BarberDto>>;
