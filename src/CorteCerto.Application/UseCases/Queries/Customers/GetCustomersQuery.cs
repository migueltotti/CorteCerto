using CorteCerto.Application.Common;
using CorteCerto.Application.DTO;
using CorteCerto.Application.Requests;
using LiteBus.Queries.Abstractions;

namespace CorteCerto.Application.UseCases.Queries.Customers;

public record GetCustomersQuery(GetPeopleRequest Request) : IQuery<PagedResult<CustomerDto>>;
