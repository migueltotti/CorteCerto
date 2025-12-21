using CorteCerto.Application.Requests;
using CorteCerto.Application.UseCases.Commands.Barbers;
using LiteBus.Commands.Abstractions;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace CorteCerto.Api.Controllers;

[ApiController]
[Route("api/barbers")]
public class BarberCommandsController(ICommandMediator commandMediator) : Controller
{
    [HttpPost("register-profile")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> RegisterBarberProfileAsync([FromBody] RegisterBarberProfileRequest request, CancellationToken cancellationToken)
    {
        var result = await commandMediator.SendAsync(new RegisterBarberProfileCommand(request), cancellationToken);
        
        if (result.IsFailure)
            return BadRequest(result.Error);

        return Created(string.Empty, result.Data);
    }
    
    [HttpPut("profile")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateBarberProfileAsync([FromBody] UpdateBarberProfileRequest request, CancellationToken cancellationToken)
    {
        var result = await commandMediator.SendAsync(request.Adapt<UpdateBarberProfileCommand>(), cancellationToken);
        
        if (result.IsFailure)
            return BadRequest(result.Error);

        return Created(string.Empty, result.Data);
    }
    
    [HttpPut("availability")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpsertBarberAvailabilityAsync([FromBody] UpsertBarberAvailabilityRequest request, CancellationToken cancellationToken)
    {
        var result = await commandMediator.SendAsync(new UpsertBarberAvailabilityCommand(request), cancellationToken);
        
        if (result.IsFailure)
            return BadRequest(result.Error);

        return Created(string.Empty, result.Data);
    }
}