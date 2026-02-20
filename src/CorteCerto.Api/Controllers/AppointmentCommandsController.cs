using CorteCerto.Application.Requests;
using CorteCerto.Application.UseCases.Commands.Barbers;
using CorteCerto.Application.UseCases.Commands.Customers;
using CorteCerto.Application.UseCases.Commands.People;
using LiteBus.Commands.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace CorteCerto.Api.Controllers;

[ApiController]
[Route("api/v1/appointments")]
public class AppointmentCommandsController(ICommandMediator commandMediator) : Controller
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> RegisterAppointmentAsync(RegisterAppointmentRequest request, CancellationToken cancellationToken = default)
    {
        var result = await commandMediator.SendAsync(new ScheduleBarberServiceCommand(request), cancellationToken);
        
        if (result.IsFailure)
            return BadRequest(result.Error);
        
        return Created(string.Empty, result.Data);
    }
    
    [HttpPost("{id}/approve")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ApproveAppointmentAsync([FromRoute] Guid id, [FromBody] ApproveAppointmentRequest request, CancellationToken cancellationToken)
    {
        var result = await commandMediator.SendAsync(new ApproveAppointmentCommand(id, request), cancellationToken);
        
        if (result.IsFailure)
            return BadRequest(result.Error);
     
        return Ok(result.Data);
    }
    
    [HttpPost("{id}/complete")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> CompleteAppointmentAsync([FromRoute] Guid id, [FromBody] CompleteAppointmentRequest request, CancellationToken cancellationToken)
    {
        var result = await commandMediator.SendAsync(new CompleteAppointmentCommand(id, request), cancellationToken);
        
        if (result.IsFailure)
            return BadRequest(result.Error);
     
        return Ok(result.Data);
    }
    
    [HttpPost("{id}/cancel")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> CancelAppointmentAsync([FromRoute] Guid id, [FromBody] CancelAppointmentRequest request, CancellationToken cancellationToken)
    {
        var result = await commandMediator.SendAsync(new CancelAppointmentCommand(id, request), cancellationToken);
        
        if (result.IsFailure)
            return BadRequest(result.Error);
     
        return Ok(result.Data);
    }
}