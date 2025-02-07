using erp.domain.Entities;
using MediatR;

namespace erp.application.Commands.Orders.ConfirmPayment;

public class ConfirmPaymentCommand : IRequest<Order>
{
    public int OrderId { get; set; }
}
