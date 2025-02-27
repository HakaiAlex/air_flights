using Domain.Interfaces;

namespace Application.Services;

public class PaymentService(IPaymentRepository paymentRepository)
{
    private readonly IPaymentRepository _paymentRepository = paymentRepository;

    public Task AddPaymentAsync(IPaymentRepository entity)
    {
        throw new NotImplementedException();
    }

    public Task DeletePaymentAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<IPaymentRepository>> GetPaymentsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IPaymentRepository> GetPaymentByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdatePaymentAsync(IPaymentRepository entity)
    {
        throw new NotImplementedException();
    }
}
