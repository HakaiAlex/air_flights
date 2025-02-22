using Domain.Entities;
using Domain.Interfaces;

namespace Application.Repositories;

public class PaymentRepository : IPaymentRepository
{
    public Task AddAsync(Payment entity)
    {
        throw new NotImplementedException();
    }

    public Task Create(Payment entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
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

    public Task Save()
    {
        throw new NotImplementedException();
    }

    public Task Update(Payment entity)
    {
        throw new NotImplementedException();
    }
}
