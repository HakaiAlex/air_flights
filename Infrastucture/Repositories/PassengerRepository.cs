using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class PassengerRepository(DbContext dbContext) : BaseRepository<Payment>(dbContext), IPassengerRepository
{
    public async Task<string> GetFullNameById(Guid id)
    {
        var passenger = await _context.Set<Payment>()
            .FindAsync(id)
            ?? throw new KeyNotFoundException($"{typeof(Payment)} with id {id} was not found.");
        return passenger.FullName!;
    }

    public async Task<Payment> GetPassengerByDocumentNumberAsync(string documentNumber)
    {
        return await _context.Set<Payment>()
            .FindAsync(documentNumber)
            ?? throw new KeyNotFoundException($"{typeof(Payment)} with documentNumber {documentNumber} was not found.");
    }

    public Task<IEnumerable<Payment>> GetPassengersByUserIdAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public async Task<string> GetPassportById(Guid id)
    {
        var passenger = await _context.Set<Payment>()
            .FindAsync(id)
            ?? throw new KeyNotFoundException($"{typeof(Payment)} with id {id} was not found.");
        return passenger.Passport!;
    }
}
