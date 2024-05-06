using erp.api.Services;
using erp.application.Commands.Login;
using erp.application.DTO;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace erp.api.Controllers;

[Route("[controller]")]
[ApiController]
public class TokenController : ControllerBase
{
    private readonly IMediator _mediator;

    public TokenController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginCommand command)
    {
        var user = await _mediator.Send(command);
        //var login = user.Adapt<LoginDTO>();
        var token = TokenService.GenerateToken(user);
        return Ok(new { token });
    }
}
