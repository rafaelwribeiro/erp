using erp.domain.Abstractions;
using erp.domain.Entities;
using erp.infra.Context;
using System.Linq.Expressions;

namespace erp.infra.Repositories;

public class StockMovementRepository : Repository<StockMovement>, IStockMovementRepository
{
    public StockMovementRepository(AppDbContext db) : base(db)
    {
    }
}
