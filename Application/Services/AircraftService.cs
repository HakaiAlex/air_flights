using Domain.Interfaces;

namespace Application.Services;

public class AircraftService(IAircraftRepository aircraftRepository)
{
    private readonly IAircraftRepository _aircraftRepository = aircraftRepository;

    public Task AddAircraftAsync(IAircraftRepository entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAircraftAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<IAircraftRepository>> GetAircraftsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IAircraftRepository> GetAircraftByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAircraftAsync(IAircraftRepository entity)
    {
        throw new NotImplementedException();
    }
}
