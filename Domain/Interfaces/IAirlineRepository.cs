using Domain.Entities;
using Domain.Interfaces.Common;

namespace Domain.Interfaces;

public interface IAirlineRepository : IBaseRepository<Airline>
{
    Task<IEnumerable<Aircraft>> GetAircraftById(Guid id);
}
