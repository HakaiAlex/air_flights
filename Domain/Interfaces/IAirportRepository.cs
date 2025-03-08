using Domain.Entities;
using Domain.Interfaces.Common;
using System.Collections;

namespace Domain.Interfaces;

public interface IAirportRepository : IBaseRepository<Airport>
{
    Task<Airport> GetAirportByCodeAsync(string code);
    Task<IEnumerable<Airport>> GetAirportsByCityAsync(string city);
}
