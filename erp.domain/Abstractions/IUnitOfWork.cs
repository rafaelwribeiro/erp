namespace erp.domain.Abstractions;

public interface IUnitOfWork
{
    IProductRepository ProductRepository {get; }
    IStockMovementRepository StockMovementRepository { get; }    
    Task CommitAsync();
    Task RollBackAsync();
}