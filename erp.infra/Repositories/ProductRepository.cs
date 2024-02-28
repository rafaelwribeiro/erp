using erp.domain.Abstractions;
using erp.domain.Entities;
using erp.infra.Context;

namespace erp.infra.Repositories;

public class ProductRepository : IProductRepository
{
    protected readonly AppDbContext db;
    public ProductRepository(AppDbContext _db)
    {
        db = _db;
    }
    public async Task<Product> Add(Product entity)
    {
        await db.Products.AddAsync(entity);
        return entity;
    }

    public async Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Product>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<Product?> GetById(int id)
    {
        return await db.Products.FindAsync(id);
    }

    public async Task<Product> Update(Product entity)
    {
        throw new NotImplementedException();
    }
}