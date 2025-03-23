using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class AirportRepository(DbContext dbContext) : BaseRepository<Airport>(dbContext), IAirportRepository
{
    public async Task<Airport> GetAirportByCodeAsync(string code)
    {
        return await _context.Set<Airport>().FindAsync(code)
            ?? throw new KeyNotFoundException($"{typeof(Airport)} with ID {code} was not found.");
    }

    public async Task<IEnumerable<Airport>> GetAirportsByCityAsync(string city)
    {
        return await _context.Set<Airport>()
            .Where(c => c.City == city)
            .ToListAsync();
    }
}
