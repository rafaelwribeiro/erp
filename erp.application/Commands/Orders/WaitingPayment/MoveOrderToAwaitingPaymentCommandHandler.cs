using erp.domain.Abstractions;
using erp.domain.Entities;
using erp.domain.Exceptions;
using MediatR;

namespace erp.application.Commands.Orders.WaitingPayment;

internal class MoveOrderToAwaitingPaymentCommandHandler : IRequestHandler<MoveOrderToAwaitingPaymentCommand, Order>
{
    private readonly IUnitOfWork _unitOfWork;

    public MoveOrderToAwaitingPaymentCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Order> Handle(MoveOrderToAwaitingPaymentCommand request, CancellationToken cancellationToken)
    {
        var repo = _unitOfWork.OrderRepository;

        var order = await repo.GetById(request.OrderId);
        if (order is null)
            throw new KeyNotFoundException("Order not found");

        if(!order.IsOrderInProgress())
            throw new BusinessRuleException("Order is not in a valid state to advance");

        order.Status = OrderStatus.AwaitingPayment;

        repo.Update(order);

        await _unitOfWork.CommitAsync();
        return order;
    }
}
