using erp.domain.Abstractions;
using erp.domain.Entities;
using Mapster;
using MediatR;

namespace erp.application.Commands.Orders.New;

internal class NewOrderCommandHandler : IRequestHandler<NewOrderCommand, Order>
{
    private readonly IUnitOfWork _unitOfWork;

    public NewOrderCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Order> Handle(NewOrderCommand request, CancellationToken cancellationToken)
    {
        var orderRepo = _unitOfWork.OrderRepository;

        var order = await orderRepo.GetByFilter(o => o.Status == OrderStatus.Created);
        if (order != null) return order; //temporário, remover isto quando existir o controle de caixa 

        order = request.Adapt<Order>();
        order.Status = OrderStatus.Created;

        var newOrder = await orderRepo.Add(order);

        await _unitOfWork.CommitAsync();
        return newOrder;
    }
}
