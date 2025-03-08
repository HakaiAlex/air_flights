using Application.Services.Common;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class AirportService(IAirportRepository airportRepository) : BaseService<Airport>(airportRepository)
{
    private readonly IAirportRepository _airportRepository = airportRepository;

    public async Task<Airport> GetAirportByCodeAsync(string code) =>
        await _airportRepository.GetAirportByCodeAsync(code);
    public async Task<IEnumerable<Airport>> GetAirportsByCityAsync(string city) =>
        await _airportRepository.GetAirportsByCityAsync(city);
}
