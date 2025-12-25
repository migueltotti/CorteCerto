using CorteCerto.Application.Requests;
using CorteCerto.Application.UseCases.Commands.People;
using LiteBus.Commands.Abstractions;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace CorteCerto.Api.Controllers;

[ApiController]
[Route("api/people")]
public class PeopleCommandsController(ICommandMediator commandMediator) : Controller
{
    [HttpPost("create-account")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateAccountAsync([FromBody] CreateAccountRequest request, CancellationToken cancellationToken)
    {
        var result = await commandMediator.SendAsync(new CreateAccountCommand(request), cancellationToken);
        
        if (result.IsFailure)
            return BadRequest(result.Error);

        return Created(string.Empty, result.Data);
    }
    
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
}