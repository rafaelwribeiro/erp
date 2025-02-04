using erp.application.Commands.Orders.New;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace erp.api.Controllers;

[Route("[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly IMediator _mediator;

    public OrderController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
	public async Task<IActionResult> PostNewOrder(NewOrderCommand command)
    {
        var order = await _mediator.Send(command);
        return Ok(order);
    }
}
