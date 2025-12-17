using CorteCerto.Application.Requests;
using CorteCerto.Application.UseCases.Queries.Customers;
using LiteBus.Queries.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace CorteCerto.Api.Controllers;

[ApiController]
[Route("api/customers")]
public class CustomerQueriesController(IQueryMediator queryMediator) : Controller
{
    [HttpGet]
    public async Task<IActionResult> GetCustomersWithFilterAsync([FromRoute] GetPeopleRequest request, CancellationToken cancellationToken = default)
    {
        var barbers = await queryMediator.QueryAsync(new GetCustomersQuery(request),  cancellationToken);
        
        return Ok(barbers);
    }
}