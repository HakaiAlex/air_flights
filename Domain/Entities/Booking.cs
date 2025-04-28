using Domain.Common;

namespace Domain.Entities;

public class Booking(Guid id, string fullName, string status, DateTime createdAt) : BaseEntity<Guid>(id)
{
    public required string FullName { get; init; } = fullName;
    public required string Status { get; init; } = status;
    public required DateTime CreatedAt { get; init; } = createdAt;

    public Guid UserId { get; private set; }
    public User User { get; private set; } = null!;

    private readonly List<Ticket> _tickets = [];
    public IReadOnlyCollection<Ticket> Tickets => _tickets.AsReadOnly();
}
