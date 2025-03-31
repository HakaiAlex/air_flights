using Domain.Common;

namespace Domain.Entities;

public class Passenger : Base
{
    public required string FullName { get; init; }
    public required DateOnly DateOfBirth { get; init; }
    public required string Passport { get; init; }

    private readonly List<Ticket> _tickets = [];
    public IReadOnlyCollection<Ticket> Tickets => _tickets.AsReadOnly();

    private Passenger() { }

    public Passenger(string fullName, DateOnly dateOfBirth, string passport)
    {
        Id = Guid.NewGuid();
        FullName = fullName;
        DateOfBirth = dateOfBirth;
        Passport = passport;
    }

    public void AddTicket(Ticket ticket)
        => _tickets.Add(ticket ?? throw new ArgumentNullException(nameof(ticket)));

    public void RemoveTicket(Ticket ticket)
        => _tickets.Remove(ticket ?? throw new ArgumentNullException(nameof(ticket)));
}
