using Domain.Entities;
using Domain.Interfaces;

namespace Infrastracture.Repositories;

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

    public Task<IEnumerable<Booking>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Booking>> GetBookingsByDateAsync(DateTime date)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Booking>> GetBookingsByUserIdAsync(Guid userId)
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
