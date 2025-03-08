using Application.Services.Common;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class TicketService(ITicketRepository ticketRepository) : BaseService<Ticket>(ticketRepository)
{
    private readonly ITicketRepository _ticketRepository = ticketRepository;

    public async Task<IEnumerable<Ticket>> GetTicketsByBookingIdAsync(Guid bookingId) =>
        await _ticketRepository.GetTicketsByBookingIdAsync(bookingId);

    public async Task<IEnumerable<Ticket>> GetTicketsByPassengerIdAsync(Guid passengerId) =>
        await _ticketRepository.GetTicketsByPassengerIdAsync(passengerId);
}
