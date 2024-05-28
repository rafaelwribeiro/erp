using erp.domain.Abstractions;
using erp.domain.Entities;
using Mapster;
using MediatR;

namespace erp.application.Commands.NewOrder;

public class NewOrderCommandHandler : IRequestHandler<NewOrderCommand, Order>
{
    private readonly IUnitOfWork _unitOfWork;

    public NewOrderCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Order> Handle(NewOrderCommand request, CancellationToken cancellationToken)
    {
        var newOrder = request.Adapt<Order>();
        newOrder.Status = OrderStatus.Pending;
        await _unitOfWork.CommitAsync();
        return newOrder;
    }
}
