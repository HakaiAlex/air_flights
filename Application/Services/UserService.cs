using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Common;

namespace Application.Services;

public class UserService(IUserRepository userRepository)
{
    private readonly IUserRepository _userRepository = userRepository;

    public Task AddUserAsync(IUserRepository entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteUserAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<IUserRepository>> GetUsersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IUserRepository> GetUserByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateUserAsync(IUserRepository entity)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetUserByEmailAsync(string email)
    {
        throw new NotImplementedException();
    }
}
