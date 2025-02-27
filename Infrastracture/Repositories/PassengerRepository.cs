using Domain.Entities;
using Domain.Interfaces;

namespace Application.Repositories;

public class PassengerRepository : IPassengerRepository
{
    public Task AddAsync(Passenger entity)
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

    public Task<IEnumerable<Passenger>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Passenger> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetFullNameById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetPassportById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Ticket>> GetTicketsById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Ticket>> GetTicketsByPassport(string passport)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Passenger entity)
    {
        throw new NotImplementedException();
    }
}
