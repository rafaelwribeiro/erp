using erp.domain.Enumerators;
using erp.domain.Exceptions;

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

    public void Validate()
    {
        if (Amount < 0)
            throw new BusinessRuleException("Stock Movement must be greater then Zero");

        if (UnitValue < 0)
            throw new BusinessRuleException("Unit value must be greater then Zero");

        if (!Enum.IsDefined(typeof(StockMovementType), Type))
            throw new BusinessRuleException("Invalid movment type");
    }
}
