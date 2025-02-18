using erp.domain.Exceptions;

namespace erp.domain.Entities;

public sealed class Product : Entity
{
    public string Name { get; set; } = "";
    public decimal Cost { get; set; } = 0;
    public decimal Price { get; set; } = 0;
    public int StockQuantity { get; set; } = 0;
    public string BarCode { get; set; } = string.Empty;

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

        if (this.Cost <= 0)
            throw new BusinessRuleException("Cost must be greater then Zero.");

        if (this.Price <= 0)
            throw new BusinessRuleException("Price must be greater then Zero.");

        if (this.Price <= this.Cost)
            throw new BusinessRuleException("Price must be greater then Cost.");

        if (this.StockQuantity < 0)
            throw new BusinessRuleException("Stock Quantity must be greater then Zero.");
        
        if (this.BarCode.Length < 8)
            throw new BusinessRuleException("BarCode should have at least 8 characteres.");
    }
}