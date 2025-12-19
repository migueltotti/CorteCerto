using CorteCerto.Application.Common;
using CorteCerto.Application.DTO;
using CorteCerto.Application.Requests;
using CorteCerto.Domain.Filters;
using LiteBus.Queries.Abstractions;
namespace CorteCerto.Application.UseCases.Queries.People;

public record GetServicesQuery(GetServicesRequest Request) : IQuery<PagedResult<ServiceDto>>;
