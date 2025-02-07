using erp.domain.Abstractions;
using erp.domain.Entities;
using erp.domain.Enumerators;
using Mapster;
using MediatR;

namespace erp.application.Commands.Orders.New;

public class NewOrderCommandHandler : IRequestHandler<NewOrderCommand, Order>
{
    private readonly IUnitOfWork _unitOfWork;

    public NewOrderCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Order> Handle(NewOrderCommand request, CancellationToken cancellationToken)
    {
        var orderRepo = _unitOfWork.OrderRepository;
        var order = request.Adapt<Order>();
        order.Status = OrderStatus.Created;

        var newOrder = await orderRepo.Add(order);
        //await MoveStock(newOrder);

        await _unitOfWork.CommitAsync();
        return newOrder;
    }
}
