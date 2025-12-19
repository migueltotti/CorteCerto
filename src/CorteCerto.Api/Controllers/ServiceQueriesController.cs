using CorteCerto.Application.Requests;
using CorteCerto.Application.UseCases.Queries.People;
using LiteBus.Queries.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace CorteCerto.Api.Controllers;

[ApiController]
[Route("api/services")]
public class ServiceQueriesController(IQueryMediator queryMediator) : Controller
{
    [HttpGet]
    public async Task<IActionResult> GetServicesWithFilterAsync([FromQuery] GetServicesRequest request, CancellationToken cancellationToken = default)
    {
        var services = await queryMediator.QueryAsync(new GetServicesQuery(request), cancellationToken);
        
        return Ok(services);
    }
}