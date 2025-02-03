using erp.domain.Enumerators;

namespace erp.domain.Entities;

public sealed class StockMovement : Entity
{
    public int ProductId { get; set; }
    public Product? Product { get; set; }
    public int Amount { get; set; }
    public decimal UnitValue { get; set; }
    public decimal Total { get; set; }
    public StockMovementType Type { get; set; } = StockMovementType.In;
    public string Description { get; set; } = string.Empty;

    public StockMovement()
    {
    }
    public StockMovement(Product product, int amount, decimal unitValue, StockMovementType type, string description)
    {
        this.Product = product;
        this.ProductId = product.Id;
        this.Amount = amount;
        this.UnitValue = unitValue;
        this.Total = amount * unitValue;
        this.Type = type;
        this.Description = description;
    }
}
