using CorteCerto.Application.Requests;
using CorteCerto.Application.UseCases.Commands.People;
using LiteBus.Commands.Abstractions;
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
}