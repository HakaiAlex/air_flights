using Domain.Common;

namespace Domain.Entities;

public class Payment : Base
{
    public decimal Amount { get; private set; } = default;
    public string Status { get; private set; } = string.Empty;
    public string PaymentMethod { get; private set; } = string.Empty;
    public DateTime CreatedAt { get; private set; } = default;

    private readonly List<Ticket> _tickets = [];
    public IReadOnlyCollection<Ticket> Tickets => _tickets.AsReadOnly();

    private Payment() { }

    public Payment(decimal amount, string status, string paymentMethod)
    {
        Id = Guid.NewGuid();
        Amount = amount;
        Status = status;
        PaymentMethod = paymentMethod;
        CreatedAt = DateTime.Now;
    }

    public void AddTicket(Ticket ticket)
        => _tickets.Add(ticket ?? throw new ArgumentNullException(nameof(ticket)));

    public void RemoveTicket(Ticket ticket)
        => _tickets.Remove(ticket ?? throw new ArgumentNullException(nameof(ticket)));
}
