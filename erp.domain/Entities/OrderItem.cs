using System.ComponentModel.DataAnnotations;

namespace erp.domain.Entities;

public class OrderItem : Entity
{
    public int OrderId { get; set; }
    public Order? Order { get; set; }
    public int ProductId { get; set; }
    public Product? Product { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; } // Desconto por item
    public decimal TotalPrice { get; set; }
}
