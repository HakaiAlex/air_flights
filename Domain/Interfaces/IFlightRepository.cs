﻿using Domain.Entities;
using Domain.Interfaces.Common;

namespace Domain.Interfaces;

public interface IFlightRepository : IBaseRepository<Flight>
{
    Task<IEnumerable<Ticket>> GetTicketsById(Guid id);
}
