using erp.domain.Entities;
using MediatR;

namespace erp.application.Commands.UpdateProduct;

public class UpdateProductCommand : IRequest
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public decimal Cost { get; set; } = 0;
    public decimal Price { get; set; } = 0;
    //public int StockQuantity { get; set; } = 0;
}
