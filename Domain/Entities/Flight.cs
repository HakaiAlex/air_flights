using Domain.Common;

namespace Domain.Entities;

public class Flight(Guid id, DateTime departure, DateTime arrival) : BaseEntity<Guid>(id)
{
    public required DateTime Departure { get; init; } = departure;
    public required DateTime Arrival { get; init; } = arrival;

    public Guid FromAirportId { get; private set; }
    public Guid ToAirportId { get; private set; }
    public Guid AircraftId { get; private set; }

    public Airport FromAirport { get; private set; } = null!;
    public Airport ToAirport { get; private set; } = null!;
    public Aircraft Aircraft { get; private set; } = null!;

    private readonly List<Ticket> _tickets = [];
    public IReadOnlyCollection<Ticket> Tickets => _tickets.AsReadOnly();
}
