using erp.domain.Enumerators;

namespace erp.domain.Entities;

public sealed class StockMovement : Entity
{
    public int ProductId { get; set; }
    public Product? Product { get; set; }
    public int Amount { get; set; }
    public StockMovementType Type { get; set; } = StockMovementType.In;
    public string Description { get; set; } = string.Empty;
}
