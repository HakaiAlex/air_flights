using Domain.Interfaces;

namespace Application.Services;

public class TicketService(ITicketRepository ticketRepository)
{
    private readonly ITicketRepository _ticketRepository = ticketRepository;

    public Task AddTicketAsync(ITicketRepository entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteTicketAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ITicketRepository>> GetTicketsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ITicketRepository> GetTicketByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateTicketAsync(ITicketRepository entity)
    {
        throw new NotImplementedException();
    }
}
