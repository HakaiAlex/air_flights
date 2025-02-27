using Domain.Entities;
using Domain.Interfaces;

namespace Application.Repositories;

public class TicketRepository : ITicketRepository
{
    public Task AddAsync(Ticket entity)
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

    public Task<IEnumerable<Ticket>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Ticket> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Ticket entity)
    {
        throw new NotImplementedException();
    }
}
