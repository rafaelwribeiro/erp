using erp.domain.Entities;
using MediatR;

namespace erp.application.Commands.Orders.ConfirmOrder;

public class ConfirmOrderCommand: IRequest<Order>
{
    public int OrderId { get; set; }
}
