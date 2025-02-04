using erp.domain.Abstractions;
using erp.domain.Entities;
using MediatR;

namespace erp.application.Commands.Orders.ApplyDiscountShippingAditionalExpense;

internal class ApplyDiscountShippingAditionalExpenseCommandHandler : IRequestHandler<ApplyDiscountShippingAditionalExpenseCommand, Order>
{
    private readonly IUnitOfWork _unitOfWork;

    public ApplyDiscountShippingAditionalExpenseCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Order> Handle(ApplyDiscountShippingAditionalExpenseCommand request, CancellationToken cancellationToken)
    {
        var repoOrder = _unitOfWork.OrderRepository;
        var repoProduct = _unitOfWork.ProductRepository;

        var order = await repoOrder.GetById(request.OrderId);
        if (order is null)
            throw new KeyNotFoundException($"Order with Id {request.OrderId} does not exists");

        order.ShippingCost = request.ShippingCost;
        order.GlobalDiscount = request.GlobalDiscount;
        order.AdditionalExpenses = request.AdditionalExpenses;
        order.CalculateTotal();

        repoOrder.Update(order);

        await _unitOfWork.CommitAsync();

        return order;
    }
}
