using erp.application.Commands.CreatePaymentMethod;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace erp.api.Controllers;

[Route("[controller]")]
[ApiController]
public class PaymentMethodController : ControllerBase
{
    private readonly IMediator _mediator;

    public PaymentMethodController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Post(CreatePaymentMethodCommand request)
    {
        var paymentMethod = await _mediator.Send(request);
        return Ok(paymentMethod);
    }
}
