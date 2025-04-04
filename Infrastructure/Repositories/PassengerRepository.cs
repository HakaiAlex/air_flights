using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class PassengerRepository(DbContext dbContext) : BaseRepository<Passenger>(dbContext), IPassengerRepository
{
    public async Task<string> GetFullNameById(Guid id)
    {
        var passenger = await _context.Set<Passenger>()
            .FindAsync(id)
            ?? throw new KeyNotFoundException($"{typeof(Payment)} with id {id} was not found.");
        return passenger.FullName!;
    }

    public async Task<Passenger> GetPassengerByDocumentNumberAsync(string documentNumber)
    {
        return await _context.Set<Passenger>()
            .FindAsync(documentNumber)
            ?? throw new KeyNotFoundException($"{typeof(Passenger)} with documentNumber {documentNumber} was not found.");
    }

    public Task<IEnumerable<Passenger>> GetPassengersByUserIdAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public async Task<string> GetPassportById(Guid id)
    {
        var passenger = await _context.Set<Passenger>()
            .FindAsync(id)
            ?? throw new KeyNotFoundException($"{typeof(Payment)} with id {id} was not found.");
        return passenger.Passport!;
    }
}
