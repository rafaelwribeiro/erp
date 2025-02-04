using erp.domain.Entities;
using MediatR;

namespace erp.application.Commands.Orders.RemoveItem;

public class RemoveItemCommand : IRequest<Order>
{
    public int OrderId { get; set; }
    public int ItemId { get; set; }
}
