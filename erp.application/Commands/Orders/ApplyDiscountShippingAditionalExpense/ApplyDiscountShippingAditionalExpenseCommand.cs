using erp.domain.Entities;
using MediatR;

namespace erp.application.Commands.Orders.ApplyDiscountShippingAditionalExpense;

public class ApplyDiscountShippingAditionalExpenseCommand : IRequest<Order>
{
    public int OrderId { get; set; }
    public decimal GlobalDiscount { get; set; } // Desconto global aplicado a todo o pedido
    public decimal ShippingCost { get; set; } // Custo do frete
    public decimal AdditionalExpenses { get; set; } // Despesas acessórias
}
