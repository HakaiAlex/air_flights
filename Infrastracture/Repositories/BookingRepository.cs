using Domain.Entities;
using Domain.Interfaces;

namespace Application.Repositories;

public class BookingRepository : IBookingRepository
{
    public Task AddAsync(Booking entity)
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

    public Task<IEnumerable<Booking>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Ticket>> GetAllTicketsByBookingId(Guid Id)
    {
        throw new NotImplementedException();
    }

    public Task<Booking> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Booking entity)
    {
        throw new NotImplementedException();
    }
}
