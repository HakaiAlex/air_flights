using Domain.Entities;
using Domain.Interfaces;

namespace Application.Repositories;

public class AirlineRepository : IAirlineRepository
{
    public Task AddAsync(Airline entity)
    {
        throw new NotImplementedException();
    }

    public Task Create(Airline entity)
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

    public Task<IEnumerable<Aircraft>> GetAircraftById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Airline>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Airline> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task Save()
    {
        throw new NotImplementedException();
    }

    public Task Update(Airline entity)
    {
        throw new NotImplementedException();
    }
}
