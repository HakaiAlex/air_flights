using Application.Services.Common;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class UserService(IUserRepository userRepository) : BaseService<User>(userRepository)
{
    private readonly IUserRepository _userRepository = userRepository;

    public async Task<User> GetUserByEmailAsync(string email) =>
        await _userRepository.GetUserByEmailAsync(email);
}
