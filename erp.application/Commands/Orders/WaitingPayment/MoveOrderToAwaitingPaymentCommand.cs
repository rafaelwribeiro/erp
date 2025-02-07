using erp.domain.Entities;
using MediatR;

namespace erp.application.Commands.Orders.WaitingPayment;

public class MoveOrderToAwaitingPaymentCommand : IRequest<Order>
{
    public int OrderId { get; set; }
}
