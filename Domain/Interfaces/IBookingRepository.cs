using Domain.Entities;
using Domain.Interfaces.Common;

namespace Domain.Interfaces;

public interface IBookingRepository : IBaseRepository<Booking>
{
    Task<IEnumerable<Ticket>> GetAllTicketsByBookingId(Guid Id);
}
