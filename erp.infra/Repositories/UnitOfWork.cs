using erp.domain.Abstractions;
using erp.infra.Context;

namespace erp.infra.Repositories;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private IProductRepository? _productRepo;
    private IStockMovementRepository? _stockMovementRepository;
    private IUserRepository? _userRepository;
    private ICustomerRepository? _customerRepository;
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

    public IStockMovementRepository StockMovementRepository
    {
        get
        {
            return _stockMovementRepository = _stockMovementRepository ?? new StockMovementRepository(_context);
        }
    }
    
    public IUserRepository UserRepository
    {
        get
        {
            return _userRepository = _userRepository ?? new UserRepository(_context);
        }
    }

    public ICustomerRepository CustomerRepository
    {
        get
        {
            return _customerRepository = _customerRepository ?? new CustomerRepository(_context);
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