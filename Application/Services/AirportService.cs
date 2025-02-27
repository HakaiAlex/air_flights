using Domain.Interfaces;

namespace Application.Services;

public class AirportService(IAirportRepository airportRepository)
{
    private readonly IAirportRepository _airportRepository = airportRepository;

    public Task AddAirportAsync(IAirportRepository entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAirportAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<IAirportRepository>> GetAirportsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IAirportRepository> GetAirportByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAirportAsync(IAirportRepository entity)
    {
        throw new NotImplementedException();
    }
}
