using Domain.Entities;
using Domain.Interfaces;

namespace Application.Repositories;

public class FlightRepository : IFlightRepository
{
    public Task AddAsync(Flight entity)
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

    public Task<IEnumerable<Flight>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Flight> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Ticket>> GetTicketsById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Flight entity)
    {
        throw new NotImplementedException();
    }
}
