using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class TicketRepository(DbContext dbContext) : BaseRepository<Ticket>(dbContext), ITicketRepository
{
    public async Task<IEnumerable<Ticket>> GetTicketsByBookingIdAsync(Guid bookingId)
    {
        return await _context.Set<Ticket>()
            .Where(t => t.BookingId == bookingId)
            .ToListAsync()
            ?? throw new KeyNotFoundException($"Tickets with Booking id {bookingId} were not found.");
    }

    public async Task<IEnumerable<Ticket>> GetTicketsByPassengerIdAsync(Guid passengerId)
    {
        return await _context.Set<Ticket>()
            .Where(t => t.PassengerId == passengerId)
            .ToListAsync()
            ?? throw new KeyNotFoundException($"Tickets with Passenger id {passengerId} were not found.");
    }
}
