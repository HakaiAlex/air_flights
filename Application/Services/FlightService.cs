using Domain.Interfaces;

namespace Application.Services;

public class FlightService(IFlightRepository flightRepository)
{
    private readonly IFlightRepository _flightRepository = flightRepository;

    public Task AddFlightAsync(IFlightRepository entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteFlightAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<IFlightRepository>> GetFlightsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IFlightRepository> GetFlightByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateFlightAsync(IFlightRepository entity)
    {
        throw new NotImplementedException();
    }
}
