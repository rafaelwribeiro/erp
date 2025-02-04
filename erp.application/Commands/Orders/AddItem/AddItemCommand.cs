using erp.domain.Entities;
using MediatR;

namespace erp.application.Commands.Orders.AddItem;


public class AddItemCommand : IRequest<Order>
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; } // Desconto por item
}
