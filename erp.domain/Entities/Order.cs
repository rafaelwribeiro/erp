using erp.domain.Exceptions;

namespace erp.domain.Entities;

public enum OrderStatus
{
    Created,
    AwaitingPayment,
    PartiallyPaid,
    Paid,
    Pending,
    Confirmed,
    Shipped,
    Delivered,
    Cancelled,
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
    public OrderStatus Status { get; set; } = OrderStatus.Created; // Status do pedido
    public decimal Total { get; set; }
    public IList<OrderPayment> Payments { get; set; } = Enumerable.Empty<OrderPayment>().ToList();

    public void CalculateTotal()
    {
        Total = OrderItems.Sum(i => i.TotalPrice)
              - GlobalDiscount // Aplicar o desconto global
              + ShippingCost // Adicionar o custo do frete
              + AdditionalExpenses; // Adicionar despesas acessórias
    }
    public void AddItem(Product product, int quantity, decimal discount, decimal unitPrice)
    {
        OrderItem item = new OrderItem
        {
            Order = this,
            OrderId = Id,
            Product = product,
            ProductId = product.Id,
            Quantity = quantity,
            Discount = discount,
            UnitPrice = unitPrice,
        };
        item.TotalPrice = item.Quantity * (item.UnitPrice - item.Discount);
        OrderItems.Add(item);
        CalculateTotal();
    }

    public void AddPayment(PaymentMethod method, decimal amount, decimal receivedAmount)
    {
        var totalAmount = Payments.Sum(x => x.Amount) + amount;
        if (totalAmount > Total)
            throw new BusinessRuleException("Payment amount exceed order total");

        if (totalAmount == Total)
            this.Status = OrderStatus.Paid;
        else
            this.Status = OrderStatus.PartiallyPaid;

        var payment = new OrderPayment();
        payment.OrderId = Id;
        payment.Order = this;
        payment.PaymentMethod = method;
        payment.PaymentMethodId = method.Id;
        payment.Status = PaymentStatus.Paid;
        payment.Amount = amount;
        payment.ReceivedAmount = receivedAmount;
        this.Payments.Add(payment);
    }

    public bool IsOrderInProgress() => this.Status == OrderStatus.Created;
    public void UpdateStatus(OrderStatus newStatus)
    {
        if (newStatus == OrderStatus.Paid && this.Status != OrderStatus.AwaitingPayment)
            throw new InvalidOperationException("O pedido só pode ser pago se estiver aguardando pagamento.");

        if (newStatus == OrderStatus.Shipped && this.Status != OrderStatus.Paid)
            throw new InvalidOperationException("O pedido só pode ser enviado se estiver pago.");

        this.Status = newStatus;
    }
    public void MarkAsPaid()
    {
        if (this.Payments.All(p => p.Status != PaymentStatus.Paid))
            throw new InvalidOperationException("O pedido só pode ser pago se houver pelo menos um pagamento confirmado.");

        UpdateStatus(OrderStatus.Paid);
    }
    public void ShipOrder()
    {
        if (this.Status != OrderStatus.Paid)
            throw new InvalidOperationException("O pedido precisa estar pago antes de ser enviado.");

        UpdateStatus(OrderStatus.Shipped);
    }
}