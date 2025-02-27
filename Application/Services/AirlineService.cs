using Domain.Interfaces;

namespace Application.Services;

public class AirlineService(IAirlineRepository airlineRepository)
{
    private readonly IAirlineRepository _airlineRepository = airlineRepository;

    public Task AddAirlineAsync(IAirlineRepository entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAirlineAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<IAirlineRepository>> GetAirlinesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IAirlineRepository> GetAirlineByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAirlineAsync(IAirlineRepository entity)
    {
        throw new NotImplementedException();
    }
}
