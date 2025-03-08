using Domain.Entities;
using Domain.Interfaces.Common;

namespace Domain.Interfaces;

public interface IBookingRepository : IBaseRepository<Booking>
{
    Task<IEnumerable<Booking>> GetBookingsByUserIdAsync(Guid userId);
    Task<IEnumerable<Booking>> GetBookingsByDateAsync(DateTime date);
}
