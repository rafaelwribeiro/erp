using erp.domain.Abstractions;
using erp.domain.Entities;
using erp.domain.Enumerators;
using erp.domain.Exceptions;
using Mapster;
using MediatR;

namespace erp.application.Commands.NewStockMovement;

public class NewStockMovementCommandHandler : IRequestHandler<NewStockMovementCommand, StockMovement>
{
    private readonly IUnitOfWork _unitOfWork;

    public NewStockMovementCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<StockMovement> Handle(NewStockMovementCommand request, CancellationToken cancellationToken)
    {
        Validate(request);
        var repoStock = _unitOfWork.StockMovementRepository;

        var repoProd = _unitOfWork.ProductRepository;

        var product = await repoProd.GetById(request.ProductId);
        if (product is null)
            throw new KeyNotFoundException("Product not found");

        var newMovement = request.Adapt<StockMovement>();

        if (newMovement.Type == StockMovementType.In)
            product.IncreaseStockQuantity(newMovement.Amount);
        else
            product.DecreaseStockQuantity(newMovement.Amount);

        repoProd.Update(product);

        newMovement.Total = newMovement.Amount * newMovement.UnitValue;

        newMovement = await repoStock.Add(newMovement);
        await _unitOfWork.CommitAsync();

        return newMovement;
    }

    private void Validate(NewStockMovementCommand request)
    {
        if (request.Amount < 0)
            throw new BusinessRuleException("Stock Movement must be greater then Zero");

        if (request.UnitValue < 0)
            throw new BusinessRuleException("Unit value must be greater then Zero");

        if (!Enum.IsDefined(typeof(StockMovementType), request.Type))
            throw new BusinessRuleException("Invalid movment type");
    }
}
