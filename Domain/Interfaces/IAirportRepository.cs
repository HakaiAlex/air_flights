using Domain.Entities;
using Domain.Interfaces.Common;
using System.Collections;

namespace Domain.Interfaces;

public interface IAirportRepository : IBaseRepository<Airport>
{
    Task<IEnumerable<Flight>> GetFlightsById(Guid id);
}
