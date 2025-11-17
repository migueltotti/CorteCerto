using CorteCerto.Application.Common;
using CorteCerto.Application.DTO;
using CorteCerto.Application.Extentions;
using CorteCerto.Domain.Filters;
using CorteCerto.Domain.Interfaces.Repositories;
using LiteBus.Queries.Abstractions;
using Mapster;

namespace CorteCerto.Application.UseCases.Queries.Customers;

public class GetCustomersQueryHandler(
    ICustomerRepository customerRepository)
    : IQueryHandler<GetCustomersQuery, PagedResult<CustomerDto>>
{
    public async Task<PagedResult<CustomerDto>> HandleAsync(GetCustomersQuery query, CancellationToken cancellationToken = default)
    {
        var filter = new PersonFilter.Builder()
            .WithId(query.Id)
            .WithName(query.Name)
            .WithEmail(query.Email)
            .WithPagination(query.PageSize, query.PageNumber)
            .Build();

        var customers = await customerRepository.GetWithFilter(filter, token: cancellationToken);

        var customersResponse = customers.Results.Adapt<List<CustomerDto>>();

        return customersResponse.ToPagedResult(customers.PageSize, customers.PageNumber);
    }
}
