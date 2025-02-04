using erp.domain.Abstractions;
using erp.domain.Entities;
using MediatR;

namespace erp.application.Commands.Orders.AddItem;

internal class AddItemCommandHandler : IRequestHandler<AddItemCommand, Order>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddItemCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Order> Handle(AddItemCommand request, CancellationToken cancellationToken)
    {
        var repoOrder = _unitOfWork.OrderRepository;
        var repoProduct = _unitOfWork.ProductRepository;

        var order = await repoOrder.GetById(request.OrderId);
        if(order is null)
            throw new KeyNotFoundException($"Order with Id {request.OrderId} does not exists");

        var product = await repoProduct.GetById(request.ProductId);
        if(product is null)
            throw new KeyNotFoundException($"Product with Id {request.ProductId} does not exists");

        order.AddItem(order.Id, product, request.Quantity, request.Discount, request.UnitPrice);

        repoOrder.Update(order);

        await _unitOfWork.CommitAsync();

        return order;
    }
}
