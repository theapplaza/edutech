using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Edutech.Api.Infrastructure.Data;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly ApplicationDbContext _context;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _context.Set<T>().FindAsync(id);
        if (entity == null)
        {
            return;
        }
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public Task<T> GetByAsync(Expression<Func<T, bool>> predicate)
    {
        return _context.Set<T>().FirstOrDefaultAsync(predicate)!;
    }

    public async Task<T> GetByIdAsync(Guid id)
    {
        return (await _context.Set<T>().FindAsync(id))!;
    }

    public async Task<T> GetByIdAsync(Guid id, QueryOptions<T>? options = null)
    {
        var entity = await _context.Set<T>().FindAsync(id);
        if (entity == null)
        {
            return null;
        }

        if (options == null)
        {
            return entity;
        }

        if (options.Includes.Count != 0)
        {
            foreach (var include in options.Includes)
            {
                var navigation = _context.Entry(entity).Navigation(include);
                navigation.Load();
            }
        }
        return entity;
    }

    public async Task UpdateAsync(int id, T entity)
    {
        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
    }
}