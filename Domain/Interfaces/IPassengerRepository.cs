using Domain.Entities;
using Domain.Interfaces.Common;

namespace Domain.Interfaces;

public interface IPassengerRepository : IBaseRepository<Payment>
{
    Task<string> GetFullNameById(Guid id);
    Task<string> GetPassportById(Guid id);
    Task<Payment> GetPassengerByDocumentNumberAsync(string documentNumber);
    Task<IEnumerable<Payment>> GetPassengersByUserIdAsync(Guid userId);
}
