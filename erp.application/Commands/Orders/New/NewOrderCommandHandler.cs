using erp.domain.Abstractions;
using erp.domain.Entities;
using erp.domain.Enumerators;
using Mapster;
using MediatR;

namespace erp.application.Commands.Orders.New;

public class NewOrderCommandHandler : IRequestHandler<NewOrderCommand, Order>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IStockMovementService _stockMovementService;

    public NewOrderCommandHandler(IUnitOfWork unitOfWork, IStockMovementService stockMovementService)
    {
        _unitOfWork = unitOfWork;
        _stockMovementService = stockMovementService;
    }

    public async Task<Order> Handle(NewOrderCommand request, CancellationToken cancellationToken)
    {
        var orderRepo = _unitOfWork.OrderRepository;
        var order = request.Adapt<Order>();
        order.Status = OrderStatus.Processing;

        var newOrder = await orderRepo.Add(order);
        //await MoveStock(newOrder);

        await _unitOfWork.CommitAsync();
        return newOrder;
    }

    private async Task MoveStock(Order newOrder)
    {
        foreach (var i in newOrder.OrderItems)
            await _stockMovementService.MoveStockAsync(i.ProductId, i.Quantity, i.UnitPrice, StockMovementType.Out, $"Venda {newOrder?.Customer?.FullName ?? ""}");
    }
}
