using erp.domain.Abstractions;
using erp.infra.Context;

namespace erp.infra.Repositories;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private IProductRepository? _productRepo;
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }


    public IProductRepository ProductRepository
    {
        get
        {
            return _productRepo = _productRepo ?? new ProductRepository(_context);
        }
    }

    public async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
    }

    public Task RollBackAsync()
    {
        return null;
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}