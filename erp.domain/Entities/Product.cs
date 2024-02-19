namespace erp.domain.Entities;

public sealed class Product : Entity
{
    public string Name { get; set; } = "";
    public decimal Price { get; set; } = 0;
    public int StockQuantity { get; set; } = 0;
}