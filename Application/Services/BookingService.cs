using Application.Services.Common;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class BookingService(IBookingRepository bookingRepository) : BaseService<Booking>(bookingRepository)
{
    private readonly IBookingRepository _bookingRepository = bookingRepository;

    public async Task<IEnumerable<Booking>> GetBookingsByUserIdAsync(Guid userId) =>
        await _bookingRepository.GetBookingsByUserIdAsync(userId);
    public async Task<IEnumerable<Booking>> GetBookingsByDateAsync(DateTime date) =>
        await _bookingRepository.GetBookingsByDateAsync(date);
}
