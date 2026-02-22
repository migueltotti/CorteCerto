using CorteCerto.Application.Requests;
using CorteCerto.Application.UseCases.Queries.Customers;
using LiteBus.Queries.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CorteCerto.Api.Controllers;

[ApiController]
[Authorize]
[Route("api/v1/customers")]
public class CustomerQueriesController(IQueryMediator queryMediator) : Controller
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetCustomersWithFilterAsync([FromQuery] GetPeopleRequest request, CancellationToken cancellationToken = default)
    {
        var barbers = await queryMediator.QueryAsync(new GetCustomersQuery(request),  cancellationToken);
        
        return Ok(barbers);
    }
}