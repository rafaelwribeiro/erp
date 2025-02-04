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
    public OrderStatus Status { get; set; } = OrderStatus.Processing; // Status do pedido
    public decimal Total { get; set; }
    public void CalculateTotal()
    {
        Total = 0;
        foreach (var item in OrderItems)
            Total += item.TotalPrice;
        Total -= GlobalDiscount; // Aplicar o desconto global
        Total += ShippingCost; // Adicionar o custo do frete
        Total += AdditionalExpenses; // Adicionar despesas acessórias
    }

    public void AddItem(int orderId, Product product, int quantity, decimal discount, decimal unitPrice)
    {
        OrderItem item = new OrderItem();
        item.Order = this;
        item.OrderId = orderId;
        item.Product = product;
        item.ProductId = product.Id;
        item.Quantity = quantity;
        item.Discount = discount;
        item.UnitPrice = unitPrice;
        item.TotalPrice = item.Quantity * (item.UnitPrice - item.Discount);
        OrderItems.Add(item);
        CalculateTotal();
    }
}