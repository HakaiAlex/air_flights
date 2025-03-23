using Domain.Common;

namespace Domain.Entities;

public class Booking : Base
{
    public string FullName { get; private set; } = string.Empty;
    public string Status { get; private set; } = string.Empty;
    public DateTime CreatedAt { get; private set; } = default;

    public Guid UserId { get; private set; }
    public User? User { get; private set; }

    private readonly List<Ticket> _tickets = [];
    public IReadOnlyCollection<Ticket> Tickets => _tickets.AsReadOnly();

    private Booking() { }
    public Booking(string fullName, string status, DateTime createdAt)
    {
        Id = Guid.NewGuid();
        FullName = fullName;
        Status = status;
        CreatedAt = createdAt;
    }

    public void AddTicket(Ticket ticket) 
        => _tickets.Add(ticket ?? throw new ArgumentNullException(nameof(ticket)));

    public void RemoveTicket(Ticket ticket)
        => _tickets.Remove(ticket ?? throw new ArgumentNullException(nameof(ticket)));
}
