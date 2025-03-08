using Domain.Entities;
using Domain.Interfaces;

namespace Infrastracture.Repositories;

public class AirportRepository : IAirportRepository
{
    public Task AddAsync(Airport entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Airport> GetAirportByCodeAsync(string code)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Airport>> GetAirportsByCityAsync(string city)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Airport>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Airport> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Airport entity)
    {
        throw new NotImplementedException();
    }
}
