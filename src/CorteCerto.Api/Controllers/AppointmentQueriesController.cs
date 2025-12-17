using CorteCerto.Application.Requests;
using CorteCerto.Application.UseCases.Queries.People;
using LiteBus.Queries.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace CorteCerto.Api.Controllers;

[ApiController]
[Route("/api/appointments")]
public class AppointmentQueriesController(IQueryMediator queryMediator) : Controller
{
    [HttpGet]
    public async Task<IActionResult> GetAppointmentsWithFilterAsync([FromQuery] GetAppointmentsRequest request, CancellationToken cancellationToken)
    {
        var result = await queryMediator.QueryAsync(new GetAppointmentsQuery(request), cancellationToken);

        return Ok(result);
    }
}