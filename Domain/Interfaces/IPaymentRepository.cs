using Domain.Entities;
using Domain.Interfaces.Common;

namespace Domain.Interfaces;

public interface IPaymentRepository : IBaseRepository<Payment>
{
    Task<Payment> GetPaymentByBookingIdAsync(Guid bookingId);
    Task<IEnumerable<Payment>> GetPaymentsByUserIdAsync(Guid userId);
}
