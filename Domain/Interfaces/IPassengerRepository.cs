using Domain.Entities;

namespace Domain.Interfaces;

public interface IPassengerRepository
{
    Task<string> GetFullNameById(Guid id);
    Task<string> GetPassportById(Guid id);
    Task<IEnumerable<Ticket>> GetTicketsById(Guid id);
    Task<IEnumerable<Ticket>> GetTicketsByPassport(string passport);
}
