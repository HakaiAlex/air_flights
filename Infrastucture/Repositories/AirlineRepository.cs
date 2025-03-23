using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class AirlineRepository(DbContext dbContext) : BaseRepository<Airline>(dbContext), IAirlineRepository
{
    public async Task<Airline> GetAirlineByNameAsync(string name)
    {
        return await _context.Set<Airline>().FindAsync(name)
            ?? throw new KeyNotFoundException($"No {typeof(Airline)} with that name was found.");
    }
}
