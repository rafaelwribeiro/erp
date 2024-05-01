using erp.application.Commands.NewStockMovement;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace erp.api.Controllers;

[Route("[controller]")]
[ApiController]
public class StockController : ControllerBase
{
    private readonly IMediator _mediator;

    public StockController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> NewMovement(NewStockMovementCommand command)
    {
        var movement = await _mediator.Send(command);
        return Ok(movement);
    }
}
