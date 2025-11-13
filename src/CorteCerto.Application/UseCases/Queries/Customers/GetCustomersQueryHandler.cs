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
    : IQueryHandler<GetCustomersQuery, PagedList<CustomerDto>>
{
    public async Task<PagedList<CustomerDto>> HandleAsync(GetCustomersQuery query, CancellationToken cancellationToken = default)
    {
        var filter = new PersonFilter.Builder()
            .WithId(query.Id)
            .WithName(query.Name)
            .WithEmail(query.Email)
            .Build();

        var customers = await customerRepository.GetWithFilter(filter);

        var customersResponse = customers.Adapt<List<CustomerDto>>();

        return customersResponse.ToPagedList(query.PageNumber, query.PageSize);
    }
}
