using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class FlightRepository(DbContext dbContext) : BaseRepository<Flight>(dbContext), IFlightRepository
{
    public async Task<IEnumerable<Flight>> GetFlightsByAirportIdAsync(Guid airportId)
    {
        return await _context.Set<Flight>()
            .Include(f => f.ToAirport)
            .Include(f => f.FromAirport)
            .Where(f => f.ToAirportId == airportId || f.FromAirportId == airportId)
            .ToListAsync();
    }

    public async Task<IEnumerable<Flight>> GetFlightsByDateAsync(DateTime date)
    {
        return await _context.Set<Flight>()
            .Where(f => f.Departure.Date == date.Date)
            .ToListAsync();
    }
}
