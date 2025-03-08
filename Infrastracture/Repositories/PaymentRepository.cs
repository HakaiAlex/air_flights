using Domain.Entities;
using Domain.Interfaces;

namespace Infrastracture.Repositories;

public class PaymentRepository : IPaymentRepository
{
    public Task AddAsync(Payment entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Payment>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Payment> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Payment> GetPaymentByBookingIdAsync(Guid bookingId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Payment>> GetPaymentsByUserIdAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Payment entity)
    {
        throw new NotImplementedException();
    }
}
