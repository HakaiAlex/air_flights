using Domain.Entities;
using Domain.Interfaces;

namespace Application.Repositories;

public class AircraftRepository : IAircraftRepository
{
    public Task AddAsync(Aircraft entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Aircraft>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Aircraft> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Flight>> GetFlightByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Aircraft entity)
    {
        throw new NotImplementedException();
    }
}
