using erp.domain.Exceptions;

namespace erp.domain.Entities;

public sealed class Product : Entity
{
    public string Name { get; set; } = "";
    public decimal Price { get; set; } = 0;
    public int StockQuantity { get; set; } = 0;

    public void IncreaseStockQuantity(int amount)
    {
        StockQuantity += amount; 
    }

    public void DecreaseStockQuantity(int amount)
    {
        StockQuantity -= amount;
    }

    public void Validate()
    {
        if (string.IsNullOrEmpty(this.Name))
            throw new BusinessRuleException("Name must be informed");

        if (this.Price < 0)
            throw new BusinessRuleException("Price must be greater then Zero.");

        if (this.StockQuantity < 0)
            throw new BusinessRuleException("Stock Quantity must be greater then Zero.");

    }
}