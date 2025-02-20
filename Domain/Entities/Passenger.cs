using Domain.Common;

namespace Domain.Entities;

public class Passenger : Base
{
    public string? FullName { get; private set; }
    public DateOnly DateOfBirth { get; private set; }
    public string? Passport { get; private set; }

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
