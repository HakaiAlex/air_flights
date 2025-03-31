using Domain.Common;

namespace Domain.Entities;

public class Payment : Base
{
    public required decimal Amount { get; init; }
    public required string Status { get; init; }
    public required string PaymentMethod { get; init; }
    public required DateTime CreatedAt { get; init; }

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
