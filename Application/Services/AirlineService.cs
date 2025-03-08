using Application.Services.Common;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class AirlineService(IAirlineRepository airlineRepository) : BaseService<Airline>(airlineRepository)
{
    private readonly IAirlineRepository _airlineRepository = airlineRepository;

    public async Task<Airline> GetAirlineByNameAsync(string name) =>
        await _airlineRepository.GetAirlineByNameAsync(name);
}
