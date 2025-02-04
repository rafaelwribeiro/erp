using erp.domain.Abstractions;
using erp.domain.Entities;
using MediatR;

namespace erp.application.Commands.Orders.RemoveItem;

internal class RemoveItemCommandHandler : IRequestHandler<RemoveItemCommand, Order>
{
    private readonly IUnitOfWork _unitOfWork;

    public RemoveItemCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Order> Handle(RemoveItemCommand request, CancellationToken cancellationToken)
    {
        var repoOrder = _unitOfWork.OrderRepository;

        var order = await repoOrder.GetById(request.OrderId);
        if (order is null)
            throw new KeyNotFoundException($"Order with Id {request.OrderId} does not exists");

        var item = order.OrderItems.ToList().FirstOrDefault(i => i.Id == request.ItemId);

        if (item is null)
            throw new KeyNotFoundException($"Product with Id {request.ItemId} does not found in this order");

        order.OrderItems.Remove(item);

        repoOrder.Update(order);

        await _unitOfWork.CommitAsync();
        return order;
    }
}
