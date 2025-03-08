using Domain.Entities;
using Domain.Interfaces.Common;

namespace Domain.Interfaces;

public interface IFlightRepository : IBaseRepository<Flight>
{
    Task<IEnumerable<Flight>> GetFlightsByDateAsync(DateTime date);
    Task<IEnumerable<Flight>> GetFlightsByAirportAsync(Guid airportId);
}
