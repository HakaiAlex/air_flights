using Application.Services.Common;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class AircraftService(IAircraftRepository aircraftRepository) : BaseService<Aircraft>(aircraftRepository)
{
    private readonly IAircraftRepository _aircraftRepository = aircraftRepository;

    public async Task<Aircraft> GetAircraftByFlightIdAsync(Guid flightId) =>
        await _aircraftRepository.GetAircraftByFlightIdAsync(flightId);
    public async Task<IEnumerable<Aircraft>> GetAircraftsByAirlineIdAsync(Guid airlineId) =>
        await _aircraftRepository.GetAircraftsByAirlineIdAsync(airlineId);
}
