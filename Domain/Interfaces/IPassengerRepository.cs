using Domain.Entities;
using Domain.Interfaces.Common;

namespace Domain.Interfaces;

public interface IPassengerRepository : IBaseRepository<Passenger>
{
    Task<string> GetFullNameById(Guid id);
    Task<string> GetPassportById(Guid id);
    Task<Passenger> GetPassengerByDocumentNumberAsync(string documentNumber);
    Task<IEnumerable<Passenger>> GetPassengersByUserIdAsync(Guid userId);
}
