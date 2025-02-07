using erp.domain.Abstractions;
using erp.domain.Entities;
using MediatR;

namespace erp.application.Commands.Orders.AddPaymentMethod;

internal class AddPaymentMethodCommandHandler : IRequestHandler<AddPaymentMethodCommand, Order>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddPaymentMethodCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Order> Handle(AddPaymentMethodCommand request, CancellationToken cancellationToken)
    {
        var repoOrder = _unitOfWork.OrderRepository;
        var repoMethod = _unitOfWork.PaymentMethodRepository;

        var order = await repoOrder.GetById(request.OrderId);
        if (order is null)
            throw new KeyNotFoundException($"Order with Id {request.OrderId} does not exists");

        var validStatus = new List<OrderStatus> {
            OrderStatus.AwaitingPayment,
            OrderStatus.PartiallyPaid,
            OrderStatus.Paid,
        };

        if(!validStatus.Contains(order.Status))
            throw new KeyNotFoundException($"Invalid order status for this operation");

        var paymentMethod = await repoMethod.GetById(request.PaymentMethodId);
        if (paymentMethod is null)
            throw new KeyNotFoundException("Payment Method not found");

        order.AddPayment(paymentMethod, request.Amount, request.ReceivedAmount);

        repoOrder.Update(order);

        await _unitOfWork.CommitAsync();

        return order;
    }
}