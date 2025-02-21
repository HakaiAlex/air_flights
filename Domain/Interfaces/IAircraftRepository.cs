using Domain.Entities;
using Domain.Interfaces.Common;

namespace Domain.Interfaces;

public interface IAircraftRepository : IBaseRepository<Aircraft>
{
    Task<IEnumerable<Flight>> GetFlightByIdAsync(Guid id);
}
