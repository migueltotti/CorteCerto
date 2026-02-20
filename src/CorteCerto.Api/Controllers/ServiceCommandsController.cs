using CorteCerto.Application.Requests;
using CorteCerto.Application.UseCases.Commands.Barbers;
using LiteBus.Commands.Abstractions;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace CorteCerto.Api.Controllers;

[ApiController]
[Route("api/v1/services")]
public class ServiceCommandsController(ICommandMediator commandMediator) : Controller
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> RegisterServiceAsync([FromBody] RegisterServiceRequest request, CancellationToken cancellationToken)
    {
        var result = await commandMediator.SendAsync(request.Adapt<RegisterServiceCommand>(), cancellationToken);
        
        if (result.IsFailure)
            return BadRequest(result.Error);

        return Created(string.Empty, result.Data);
    }
    
    [HttpPut("{id:int}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateBarberProfileAsync([FromRoute] int id, [FromBody] UpdateServiceRequest request, CancellationToken cancellationToken)
    {
        var result = await commandMediator.SendAsync(new UpdateServiceCommand(
            request.BarberId,
            id,
            request.Name,
            request.Description,
            request.Price,
            request.Duration,
            request.IsAvailable
            ), cancellationToken);
        
        if (result.IsFailure)
            return BadRequest(result.Error);

        return Ok(result.Data);
    }
    
    [HttpDelete("{id:int}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpsertBarberAvailabilityAsync([FromRoute] int id, [FromBody] DeleteServiceRequest request, CancellationToken cancellationToken)
    {
        var result = await commandMediator.SendAsync(new DeleteServiceCommand(request.BarberId, id), cancellationToken);
        
        if (result.IsFailure)
            return BadRequest(result.Error);

        return Ok();
    }
}