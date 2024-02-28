namespace erp.domain.Abstractions;

public interface IUnitOfWork
{
    IProductRepository ProductRepository {get; }
    Task CommitAsync();
    Task RollBackAsync();
}