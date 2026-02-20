using CorteCerto.Application.Requests;
using CorteCerto.Application.UseCases.Queries.Barbers;
using LiteBus.Queries.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace CorteCerto.Api.Controllers;

[ApiController]
[Route("api/v1/barbers")]
public class BarberQueriesController(IQueryMediator queryMediator) : Controller
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetBarbersWithFilterAsync([FromQuery] GetPeopleRequest request, CancellationToken cancellationToken = default)
    {
        var barbers = await queryMediator.QueryAsync(new GetBarbersQuery(request),  cancellationToken);
        
        return Ok(barbers);
    }
}