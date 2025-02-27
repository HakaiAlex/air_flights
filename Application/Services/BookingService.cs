using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class BookingService(IBookingRepository bookingRepository)
{
    private IBookingRepository _bookingRepository = bookingRepository;

    public Task AddBookingAsync(IBookingRepository entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteBookingAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<IBookingRepository>> GetBookingsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IBookingRepository> GetBookingByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateBookingAsync(IBookingRepository entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Ticket>> GetAllTicketsByBookingId(Guid Id)
    {
        throw new NotImplementedException();
    }
}
