namespace erp.domain.Abstractions;

public interface IUnitOfWork
{
    IProductRepository ProductRepository {get; }
    IStockMovementRepository StockMovementRepository { get; }
    IUserRepository UserRepository { get; }
    ICustomerRepository CustomerRepository { get; }
    IOrderRepository OrderRepository { get; }
    Task CommitAsync();
    Task RollBackAsync();
}