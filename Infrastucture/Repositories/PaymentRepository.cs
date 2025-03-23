using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class PaymentRepository(DbContext dbContext) : BaseRepository<Payment>(dbContext), IPaymentRepository
{
    public async Task<Payment> GetPaymentByBookingIdAsync(Guid bookingId)
    {
        return await _context.Set<Payment>()
            .Include(p => p.Tickets)
            .FirstOrDefaultAsync(t => t.Tickets.Any(b => b.BookingId == bookingId)) 
            ?? throw new KeyNotFoundException($"Payment for BookingId {bookingId} was not found.");
    }

    public async Task<IEnumerable<Payment>> GetPaymentsByUserIdAsync(Guid userId)
    {
        return await _context.Set<Payment>()
            .Include(p => p.Tickets)
                .ThenInclude(t => t.Booking)
            .Where(p => p.Tickets.Any(
                t => t.Booking != null && t.Booking.UserId == userId))
            .ToListAsync();
    }
}
