using erp.domain.Entities;
using MediatR;

namespace erp.application.Commands.Orders.AddPaymentMethod;

public class AddPaymentMethodCommand: IRequest<Order>
{
    public int OrderId { get; set; }
    public int PaymentMethodId { get; set; }
    public decimal Amount { get; set; } // Valor pago
    public decimal ReceivedAmount { get; set; }
}
