using Domain.Interfaces;

namespace Application.Services;

public class PassengerService(IPassengerRepository passengerRepository)
{
    private readonly IPassengerRepository _passengerRepository = passengerRepository;

    public Task AddPassengerAsync(IPassengerRepository entity)
    {
        throw new NotImplementedException();
    }

    public Task DeletePassengerAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<IPassengerRepository>> GetPassengersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IPassengerRepository> GetPassengerByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdatePassengerAsync(IPassengerRepository entity)
    {
        throw new NotImplementedException();
    }
}
