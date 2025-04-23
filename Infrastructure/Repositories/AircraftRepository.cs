using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class AircraftRepository(DbContext dbContext) : BaseRepository<Aircraft>(dbContext), IAircraftRepository
{
    public async Task<Aircraft> GetAircraftByFlightIdAsync(Guid flightId)
    {
        return await _context.Set<Aircraft>()
            .FirstOrDefaultAsync(a => a.Flights.Any(f => f!.EntityId == flightId))
            ?? throw new KeyNotFoundException($"Aircraft for FlightId {flightId} was not found.");
    }

    public async Task<IEnumerable<Aircraft>> GetAircraftsByAirlineIdAsync(Guid airlineId)
    {
        return await _context.Set<Aircraft>()
            .Where(a => a.AirlineId == airlineId)
            .ToListAsync()
            ?? throw new KeyNotFoundException($"{typeof(Aircraft)}s with airline id {airlineId} were not found.");
    }
}
