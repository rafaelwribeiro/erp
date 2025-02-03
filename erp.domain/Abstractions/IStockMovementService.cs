using erp.domain.Entities;
using erp.domain.Enumerators;

namespace erp.domain.Abstractions;

public interface IStockMovementService
{
    Task<StockMovement> MoveStockAsync(int productId, int amount, decimal unitValue, StockMovementType type, string description);
}
