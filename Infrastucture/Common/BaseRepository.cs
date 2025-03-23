using Domain.Interfaces.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Common;

public abstract class BaseRepository<T>(DbContext context) : IBaseRepository<T>
    where T : class
{
    protected readonly DbContext _context = context;

    public virtual async Task<T> GetByIdAsync(Guid id) =>
        await _context.Set<T>().FindAsync(id)
        ?? throw new KeyNotFoundException($"{typeof(T)} with ID {id} was not found.");

    public virtual async Task<IEnumerable<T>> GetAllAsync() =>
        await _context.Set<T>().ToListAsync();

    public virtual async Task AddAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public virtual Task UpdateAsync(T entity)
    {
        _context.Set<T>().Update(entity);
        return _context.SaveChangesAsync();
    }

    public virtual async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity is not null)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
