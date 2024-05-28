using erp.domain.Entities;

namespace erp.application.Commands.NewOrder;

public class NewOrderItem
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; } // Desconto por item
}
