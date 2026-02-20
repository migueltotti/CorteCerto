using CorteCerto.Application.Requests;
using CorteCerto.Application.UseCases.Commands.People;
using LiteBus.Commands.Abstractions;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace CorteCerto.Api.Controllers;

[ApiController]
[Route("api/v1/people")]
public class PeopleCommandsController(ICommandMediator commandMediator) : Controller
{
    [HttpPost("login")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> LoginAsync([FromBody] LoginRequest request, CancellationToken cancellationToken)
    {
        var result = await commandMediator.SendAsync(request.Adapt<LoginCommand>(), cancellationToken);
        
        if (result.IsFailure)
            return BadRequest(result.Error);

        return Created(string.Empty, result.Data);
    }
    
    [HttpPost("refresh-token-login")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> RefreshTokenLoginAsync([FromBody] RefreshTokenLoginRequest request, CancellationToken cancellationToken)
    {
        var result = await commandMediator.SendAsync(request.Adapt<RefreshTokenLoginCommand>(), cancellationToken);
        
        if (result.IsFailure)
            return BadRequest(result.Error);

        return Created(string.Empty, result.Data);
    }
    
    [HttpPost("account/create")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateAccountAsync([FromBody] CreateAccountRequest request, CancellationToken cancellationToken)
    {
        var result = await commandMediator.SendAsync(new CreateAccountCommand(request), cancellationToken);
        
        if (result.IsFailure)
            return BadRequest(result.Error);

        return Created(string.Empty, result.Data);
    }
    
    [HttpDelete("account/delete")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> DeleteAccountAsync([FromBody] DeleteAccountRequest request, CancellationToken cancellationToken)
    {
        var result = await commandMediator.SendAsync(new DeleteAccountCommand(request.PersonId), cancellationToken);
        
        if (result.IsFailure)
            return BadRequest(result.Error);

        return Ok();
    }
    
    [HttpPatch("{id:guid}/email")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdatePersonEmailAsync([FromRoute] Guid id, [FromBody] UpdatePersonEmailRequest request, CancellationToken cancellationToken)
    {
        var result = await commandMediator.SendAsync(new UpdatePersonEmailCommand(id, request.CurrentEmail, request.NewEmail), cancellationToken);
        
        if (result.IsFailure)
            return BadRequest(result.Error);

        return Ok();
    }
    
    [HttpPatch("{id:guid}/password")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdatePersonPasswordAsync([FromRoute]Guid id, [FromBody] UpdatePersonPasswordRequest request, CancellationToken cancellationToken)
    {
        var result = await commandMediator.SendAsync(new UpdatePersonPasswordCommand(id, request.CurrentPassword, request.NewPassword), cancellationToken);
        
        if (result.IsFailure)
            return BadRequest(result.Error);

        return Ok();
    }
    
    [HttpPatch("{id:guid}/infos")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdatePersonInfosAsync([FromRoute]Guid id, [FromBody] UpdateProfileInfoRequest request, CancellationToken cancellationToken)
    {
        var result = await commandMediator.SendAsync(new UpdateProfileInfoCommand(id, request.NewName, request.NewPhoneNumber), cancellationToken);
        
        if (result.IsFailure)
            return BadRequest(result.Error);

        return Ok(result.Data);
    }
}