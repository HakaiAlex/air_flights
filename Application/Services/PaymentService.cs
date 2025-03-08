using Application.Services.Common;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Common;

namespace Application.Services;

public class PaymentService(IPaymentRepository paymentRepository) : BaseService<Payment>(paymentRepository)
{
    private readonly IPaymentRepository _paymentRepository = paymentRepository;

    public async Task<Payment> GetPaymentByBookingIdAsync(Guid bookingId) =>
        await _paymentRepository.GetPaymentByBookingIdAsync(bookingId);

    public async Task<IEnumerable<Payment>> GetPaymentsByUserIdAsync(Guid userId) =>
        await _paymentRepository.GetPaymentsByUserIdAsync(userId);
}
