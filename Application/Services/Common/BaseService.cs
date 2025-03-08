using Domain.Interfaces.Common;

namespace Application.Services.Common;

public abstract class BaseService<T>(IBaseRepository<T> repository)
    where T : class
{
    protected readonly IBaseRepository<T> _repository = repository;

    public virtual async Task<T> GetByIdAsync(Guid id) => await _repository.GetByIdAsync(id);
    public virtual async Task<IEnumerable<T>> GetAllAsync() => await _repository.GetAllAsync();
    public virtual async Task AddAsync(T entity) => await _repository.AddAsync(entity);
    public virtual async Task UpdateAsync(T entity) => await _repository.UpdateAsync(entity);
    public virtual async Task DeleteAsync(Guid id) => await _repository.DeleteAsync(id);
}
