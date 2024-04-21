using erp.domain.Abstractions;
using erp.domain.Entities;
using erp.infra.Context;

namespace erp.infra.Repositories;

public class ProductRepository : Repository<Product>, IProductRepository
{
    protected readonly AppDbContext db;
    public ProductRepository(AppDbContext _db) : base(_db)
    {
        db = _db;
    }
    
}