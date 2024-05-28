using erp.domain.Entities;
using MediatR;

namespace erp.application.Commands.NewOrder;

public class NewOrderCommand : IRequest<Order>
{
    public int CustomerId { get; set; }
    public IEnumerable<NewOrderItem> OrderItems { get; set; } = Enumerable.Empty<NewOrderItem>();
    public decimal GlobalDiscount { get; set; } // Desconto global aplicado a todo o pedido
    public decimal ShippingCost { get; set; } // Custo do frete
    public decimal AdditionalExpenses { get; set; } // Despesas acessórias
}
