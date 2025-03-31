using Domain.Common;

namespace Domain.Entities;

public class Booking : Base
{
    public required string FullName { get; init; }
    public required string Status { get; init; }
    public required DateTime CreatedAt { get; init; }

    public Guid UserId { get; private set; }
    public User User { get; private set; } = null!;

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
