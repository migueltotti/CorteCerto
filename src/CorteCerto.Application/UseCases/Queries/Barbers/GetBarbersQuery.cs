using CorteCerto.Application.Common;
using CorteCerto.Application.DTO;
using CorteCerto.Application.Requests;
using LiteBus.Queries.Abstractions;

namespace CorteCerto.Application.UseCases.Queries.Barbers;

public record GetBarbersQuery(GetPeopleRequest Request) : IQuery<PagedResult<BarberDto>>;
