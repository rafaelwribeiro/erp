using erp.domain.Entities;

namespace erp.domain.Abstractions;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAll();
    Task<Product> GetById(int id);
    Task<Product> Add(Product entity);
    Task<Product> Update(Product entity);
    Task Delete(int id);
}