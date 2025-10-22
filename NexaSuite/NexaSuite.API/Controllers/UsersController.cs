using MediatR;
using Microsoft.AspNetCore.Mvc;
using NexaSuite.Application.Users.Commands;

namespace NexaSuite.API.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateUserCommand command)
    {
        var result = await mediator.Send(command);
        return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
    }

    // Placeholder for later
    [HttpGet("{id:guid}")]
    public IActionResult GetById(Guid id) => Ok(new { id });
}
