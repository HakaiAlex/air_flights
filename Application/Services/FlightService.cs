using Application.Services.Common;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class FlightService(IFlightRepository flightRepository) : BaseService<Flight>(flightRepository)
{
    private readonly IFlightRepository _flightRepository = flightRepository;

    public async Task<IEnumerable<Flight>> GetFlightsByDateAsync(DateTime date) =>
        await _flightRepository.GetFlightsByDateAsync(date);
    public async Task<IEnumerable<Flight>> GetFlightsByAirportAsync(Guid airportId) =>
        await _flightRepository.GetFlightsByAirportAsync(airportId);
}
