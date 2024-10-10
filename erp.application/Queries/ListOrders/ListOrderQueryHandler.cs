using erp.domain.Abstractions;
using erp.domain.Entities;
using MediatR;

namespace erp.application.Queries.ListOrders;

public class ListOrderQueryHandler : IRequestHandler<ListOrderQuery, IEnumerable<Order>>
{
    private IOrderRepository _orderRepository;

    public ListOrderQueryHandler(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<IEnumerable<Order>> Handle(ListOrderQuery request, CancellationToken cancellationToken)
    {
        var fromDate = request?.FromDate ?? DateTime.MinValue;
        var toDate = request?.ToDate ?? DateTime.MaxValue;
        var list = await _orderRepository.GetManyByFilter(o => o.OrderDate >= fromDate && o.OrderDate <= toDate);
        return list;
    }
}
