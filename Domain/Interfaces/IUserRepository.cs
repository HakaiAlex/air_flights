﻿using Domain.Entities;
using Domain.Interfaces.Common;

namespace Domain.Interfaces;

public interface IUserRepository : IBaseRepository<User>
{
    Task<User> GetUserByEmailAsync(string email);
}
