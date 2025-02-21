using Domain.Common;
using Domain.Entities;

namespace Domain.Interfaces.Common;

public interface IBaseRepository<T> : IDisposable
    where T : class
{
    Task<T> GetByIdAsync(Guid id);
    Task<IEnumerable<T>> GetAllAsync();
    Task AddAsync(T entity);
    Task Update(T entity);
    Task DeleteAsync(Guid id);
    Task Create(T entity);
    Task Save();
}
