using erp.domain.Abstractions;
using erp.domain.Entities;
using erp.domain.Enumerators;
using erp.domain.Exceptions;

namespace erp.application.Service;

public class StockMovementService : IStockMovementService
{
    private readonly IUnitOfWork _unitOfWork;

    public StockMovementService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<StockMovement> MoveStockAsync(int productId, int amount, decimal unitValue, StockMovementType type, string description)
    {
        var repoStock = _unitOfWork.StockMovementRepository;

        var repoProd = _unitOfWork.ProductRepository;

        var product = await repoProd.GetById(productId);
        if(product is null)
            throw new KeyNotFoundException("Product not found");

        var newMovement = new StockMovement(product, amount, unitValue, type, description);
        newMovement.Validate();

        if (newMovement.Type == StockMovementType.In)
            product.IncreaseStockQuantity(newMovement.Amount);
        else
            product.DecreaseStockQuantity(newMovement.Amount);

        product.Cost = unitValue;//por enquanto atribui sempre o ultimo valor unitario de compra

        repoProd.Update(product);

        newMovement = await repoStock.Add(newMovement);

        return newMovement;
    }
}
