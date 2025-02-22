using Domain.Entities;
using Domain.Interfaces.Common;

namespace Domain.Interfaces;

public interface IPassengerRepository : IBaseRepository<Passenger>
{
    Task<string> GetFullNameById(Guid id);
    Task<string> GetPassportById(Guid id);
    Task<IEnumerable<Ticket>> GetTicketsById(Guid id);
    Task<IEnumerable<Ticket>> GetTicketsByPassport(string passport);
}
