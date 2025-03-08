using Domain.Entities;
using Domain.Interfaces.Common;

namespace Domain.Interfaces;

public interface IAircraftRepository : IBaseRepository<Aircraft>
{
    Task<Aircraft> GetAircraftByFlightIdAsync(Guid flightId);
    Task<IEnumerable<Aircraft>> GetAircraftsByAirlineIdAsync(Guid airlineId);
}
