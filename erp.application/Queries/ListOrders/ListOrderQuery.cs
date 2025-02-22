using erp.domain.Entities;
using MediatR;

namespace erp.application.Queries.ListOrders;

public class ListOrderQuery : IRequest<IEnumerable<Order>>
{
    public DateTime? FromDate { get; set; }
    public DateTime? ToDate { get; set; }
    public int Id { get; set; } = 0;
}
