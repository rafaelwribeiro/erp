using erp.infra.Context;
using erp.domain.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace erp.infra.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly AppDbContext _db;

    public Repository(AppDbContext db)
    {
        _db = db;
    }

    public async Task<T> Add(T entity)
    {
        await _db.Set<T>().AddAsync(entity);
        return entity;
    }

    public async Task<T> Delete(int id)
    {
        var entity = await _db.Set<T>().FindAsync(id);
        if (entity is null)
            throw new InvalidOperationException("entity not found");

        _db.Set<T>().Remove(entity);
        return entity;
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await _db.Set<T>().AsNoTracking().ToListAsync();
    }

    public async Task<T?> GetById(int id)
    {
        return await _db.Set<T>().FindAsync(id);
    }

    public async Task<T?> GetByFilter(Expression<Func<T, bool>> filter)
    {
        return await _db.Set<T>().FirstOrDefaultAsync(filter);
    }

    public async Task<IEnumerable<T>> GetManyByFilter(Expression<Func<T, bool>> filter)
    {
        return await _db.Set<T>().AsNoTracking().Where(filter).ToListAsync();
    }

    public async Task<bool> AnyByFilter(Expression<Func<T, bool>> filter)
    {
        return await _db.Set<T>().AsNoTracking().Where(filter).AnyAsync();
    }

    public void Update(T entity)
    {
        if (entity is null)
            throw new ArgumentNullException(nameof(entity));
        _db.Set<T>().Update(entity);
    }
}
