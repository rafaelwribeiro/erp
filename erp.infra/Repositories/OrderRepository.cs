using erp.domain.Abstractions;
using erp.domain.Entities;
using erp.infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace erp.infra.Repositories;

public class OrderRepository : Repository<Order>, IOrderRepository
{
    private readonly AppDbContext _db;
    public OrderRepository(AppDbContext db) : base(db)
    {
        _db = db;
    }

    public new async Task<IEnumerable<Order>> GetManyByFilter(Expression<Func<Order, bool>> filter)
    {
        return await _db.Orders.AsNoTracking()
            .Include(o => o.Customer)
            .Where(filter).ToListAsync();
    }



}
