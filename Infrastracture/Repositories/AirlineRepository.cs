using Domain.Entities;
using Domain.Interfaces;

namespace Infrastracture.Repositories;

public class AirlineRepository : IAirlineRepository
{
    public Task AddAsync(Airline entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Airline> GetAirlineByNameAsync(string name)
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

    public Task UpdateAsync(Airline entity)
    {
        throw new NotImplementedException();
    }
}
