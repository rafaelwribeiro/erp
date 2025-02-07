using erp.domain.Abstractions;
using erp.domain.Entities;
using erp.domain.Enumerators;
using MediatR;

namespace erp.application.Commands.Orders.ConfirmOrder;

internal class ConfirmOrderCommandHandler : IRequestHandler<ConfirmOrderCommand, Order>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IStockMovementService _stockMovementService;

    public ConfirmOrderCommandHandler(IUnitOfWork unitOfWork, IStockMovementService stockMovementService)
    {
        _unitOfWork = unitOfWork;
        _stockMovementService = stockMovementService;
    }

    public async Task<Order> Handle(ConfirmOrderCommand request, CancellationToken cancellationToken)
    {
        var repoOrder = _unitOfWork.OrderRepository;
        var repoMethod = _unitOfWork.PaymentMethodRepository;

        var order = await repoOrder.GetById(request.OrderId);
        if (order is null)
            throw new KeyNotFoundException($"Order with Id {request.OrderId} does not exists");

        if (order.Status != OrderStatus.Paid)
            throw new KeyNotFoundException($"Invalid order status for this operation");

        order.UpdateStatus(OrderStatus.Confirmed);
        repoOrder.Update(order);


        //invoice here

        //Reciveables

        //Cash Register or Transaction

        await MoveStock(order);

        await _unitOfWork.CommitAsync();

        return order;
    }

    private async Task MoveStock(Order order)
    {
        foreach (var i in order.OrderItems)
            await _stockMovementService.MoveStockAsync(i.ProductId, i.Quantity, i.UnitPrice, StockMovementType.Out, $"Venda {order?.Customer?.FullName ?? ""}");
    }
}
