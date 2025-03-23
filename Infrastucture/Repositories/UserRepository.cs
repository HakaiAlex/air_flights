using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class UserRepository(DbContext dbContext) : BaseRepository<User>(dbContext), IUserRepository
{
    public async Task<User> GetUserByEmailAsync(string email)
    {
        return await _context.Set<User>().FindAsync(email)
            ?? throw new KeyNotFoundException($"{typeof(User)} with ID {email} was not found.");
    }
}
