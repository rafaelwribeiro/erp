using System.ComponentModel.DataAnnotations;

namespace erp.domain.Entities;

public enum OrderStatus
{
    Pending,
    Confirmed,
    Processing,
    Shipped,
    Delivered,
    Cancelled,
    Returned,
    Completed,
    OnHold,
    PaymentPending,
    PaymentReceived,
    Backordered
}

public class Order : Entity
{
    public int CustomerId { get; set; }
    public Customer? Customer { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public IList<OrderItem> OrderItems { get; set; } = Enumerable.Empty<OrderItem>().ToList();
    public decimal GlobalDiscount { get; set; } // Desconto global aplicado a todo o pedido
    public decimal ShippingCost { get; set; } // Custo do frete
    public decimal AdditionalExpenses { get; set; } // Despesas acessórias
    public OrderStatus Status { get; set; } // Status do pedido
    public decimal TotalAmount => CalculateTotalAmount();
    private decimal CalculateTotalAmount()
    {
        decimal total = 0;
        foreach (var item in OrderItems)
            total += item.TotalPrice;
        total -= GlobalDiscount; // Aplicar o desconto global
        total += ShippingCost; // Adicionar o custo do frete
        total += AdditionalExpenses; // Adicionar despesas acessórias
        return total;
    }
}