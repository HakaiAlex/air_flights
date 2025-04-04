using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class BookingRepository(DbContext dbContext) : BaseRepository<Booking>(dbContext), IBookingRepository
{
    public async Task<IEnumerable<Booking>> GetBookingsByDateAsync(DateTime date)
    {
        return await _context.Set<Booking>()
            .Where(b => b.CreatedAt == date)
            .ToListAsync()
            ?? throw new KeyNotFoundException($"{typeof(Booking)}s with date {date} were not found.");
    }

    public async Task<IEnumerable<Booking>> GetBookingsByUserIdAsync(Guid userId)
    {
        return await _context.Set<Booking>()
        .Where(b => b.UserId == userId)
        .ToListAsync()
        ?? throw new KeyNotFoundException($"{typeof(Booking)}s with user id {userId} were not found.");
    }
}
