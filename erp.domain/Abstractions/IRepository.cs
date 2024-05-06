using System.Linq.Expressions;

namespace erp.domain.Abstractions;

public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAll();
    Task<T?> GetById(int id);
    Task<T?> GetByFilter(Expression<Func<T, bool>> filter);
    Task<IEnumerable<T>> GetManyByFilter(Expression<Func<T, bool>> filter);
    Task<bool> AnyByFilter(Expression<Func<T, bool>> filter);
    Task<T> Add(T entity);
    void Update(T entity);
    Task<T> Delete(int id);
}
