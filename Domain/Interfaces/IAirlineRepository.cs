using Domain.Entities;
using Domain.Interfaces.Common;

namespace Domain.Interfaces;

public interface IAirlineRepository : IBaseRepository<Airline>
{
    Task<Airline> GetAirlineByNameAsync(string name);
}
