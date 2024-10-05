using System.Linq.Expressions;

namespace Edutech.Api.Infrastructure.Data;

public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(Guid id, QueryOptions<T>? options);
    Task<T> GetByIdAsync(Guid id);
    Task<T> GetByAsync(Expression<Func<T, bool>> predicate);
    Task AddAsync(T entity);
    Task UpdateAsync(int id, T entity);
    Task DeleteAsync(int id);

}
