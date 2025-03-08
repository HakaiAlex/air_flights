using Domain.Entities;
using Domain.Interfaces.Common;

namespace Domain.Interfaces;

public interface ITicketRepository : IBaseRepository<Ticket>
{
    Task<IEnumerable<Ticket>> GetTicketsByBookingIdAsync(Guid bookingId);
    Task<IEnumerable<Ticket>> GetTicketsByPassengerIdAsync(Guid passengerId);
}
