using Domain.Entities;
using Domain.Interfaces;

namespace Application.Repositories;

public class AirportRepository : IAirportRepository
{
    public Task AddAsync(Airport entity)
    {
        throw new NotImplementedException();
    }

    public Task Create(Airport entity)
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

    public Task<IEnumerable<Airport>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Airport> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Flight>> GetFlightsById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task Save()
    {
        throw new NotImplementedException();
    }

    public Task Update(Airport entity)
    {
        throw new NotImplementedException();
    }
}
