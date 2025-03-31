using Application.Services.Common;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class PassengerService(IPassengerRepository passengerRepository) 
    : BaseService<Payment>(passengerRepository)
{
    private readonly IPassengerRepository _passengerRepository = passengerRepository;

    public async Task<string> GetFullNameById(Guid id) =>
        await _passengerRepository.GetFullNameById(id);

    public async Task<string> GetPassportById(Guid id) =>
        await _passengerRepository.GetPassportById(id);

    public async Task<Payment> GetPassengerByDocumentNumberAsync(string documentNumber) =>
        await _passengerRepository.GetPassengerByDocumentNumberAsync(documentNumber);

    public async Task<IEnumerable<Payment>> GetPassengersByUserIdAsync(Guid userId) =>
        await _passengerRepository.GetPassengersByUserIdAsync(userId);
}
