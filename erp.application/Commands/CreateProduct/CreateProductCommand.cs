using erp.domain.Entities;
using MediatR;

namespace erp.application.Commands.CreateProduct;

public class CreateProductCommand : IRequest<Product>
{
    public string Name { get; set; } = "";
    public decimal Price { get; set; } = 0;
    public int StockQuantity { get; set; } = 0;
}
