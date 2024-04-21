using erp.application.Commands.CreateProduct;
using erp.application.Commands.DeleteCommand;
using erp.application.Commands.UpdateProduct;
using erp.application.Queries.GetProduct;
using erp.application.Queries.ListProducts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace erp.api.Controllers;

[Route("[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var command = new GetProductQuery(id);
        var product = await _mediator.Send(command);
        return Ok(product);
    }

    [HttpGet]
    public async Task<IActionResult> List()
    {
        var products = await _mediator.Send(new ListProductsQuery());
        return Ok(products);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateProductCommand command)
    {
        var createdProduct = await _mediator.Send(command);
        return CreatedAtAction(nameof(Get), new { id = createdProduct.Id }, createdProduct);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdateProductCommand command)
    {
        command.Id = id;
        await _mediator.Send(command);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _mediator.Send(new DeleteProductCommand(id));
        return Ok();
    }
}