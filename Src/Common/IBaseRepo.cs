using System.Linq.Expressions;

namespace CommonGenericClasses;
#nullable disable
public interface IBaseRepo<TEntity> where TEntity : class
{
    Task<TEntity> AddAsync(TEntity entity);
    void Dispose();
    TEntity Edit(TEntity entity);
    Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string include = "");
    Task<List<TEntity>> GetAllAsync();
    Task<TEntity> GetByIdAsync(object id);
    TEntity Remove(TEntity entity);
    Task<TEntity> RemoveAsync(Expression<Func<TEntity, bool>> predicate);
    Task<TEntity> RemoveByIdAsync(object id);
    Task<IEnumerable<TEntity>> RemoveRangeAsync(Expression<Func<TEntity, bool>> predicate);
    Task Save();
}