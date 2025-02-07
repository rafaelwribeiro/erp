using erp.domain.Abstractions;
using erp.domain.Entities;
using erp.domain.Exceptions;
using MediatR;

namespace erp.application.Commands.Orders.ConfirmPayment;

internal class ConfirmPaymentCommandHandler : IRequestHandler<ConfirmPaymentCommand, Order>
{
    private readonly IUnitOfWork _unitOfWork;

    public ConfirmPaymentCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Order> Handle(ConfirmPaymentCommand request, CancellationToken cancellationToken)
    {
        var repo = _unitOfWork.OrderRepository;

        var order = await repo.GetById(request.OrderId);
        if (order is null)
            throw new KeyNotFoundException("Order not found");

        if (order.Status != OrderStatus.AwaitingPayment)
            throw new BusinessRuleException("Order is not in a valid state to advance");

        order.Payments.Add(new OrderPayment
        {
            
        });

        repo.Update(order);

        await _unitOfWork.CommitAsync();

        return order;
    }
}
