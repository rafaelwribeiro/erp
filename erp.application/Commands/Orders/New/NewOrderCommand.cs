using erp.domain.Entities;
using MediatR;

namespace erp.application.Commands.Orders.New;

public class NewOrderCommand : IRequest<Order>
{
    public int CustomerId { get; set; }
}
