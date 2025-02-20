using Domain.Common;

namespace Domain.Entities;

public class Flight : Base
{
    public DateTime Departure { get; private set; }
    public DateTime Arrival { get; private set; }
    public Guid FromAirportId { get; private set; }
    public Guid ToAirportId { get; private set; }
    public Guid AircraftId { get; private set; }

    public Airport? FromAirport { get; private set; }
    public Airport? ToAirport { get; private set; }
    public Aircraft? Aircraft { get; private set; }

    private readonly List<Ticket?> _tickets = [];
    public IReadOnlyCollection<Ticket?> Tickets => _tickets.AsReadOnly();

    private Flight() { }

    public Flight(DateTime departure, DateTime arrival, Airport fromAirport, Airport toAirport)
    {
        Id = Guid.NewGuid();
        Departure = departure;
        Arrival = arrival;
        FromAirport = fromAirport;
        ToAirport = toAirport;
    }

    public void AddTicket(Ticket ticket) 
        => _tickets.Add(ticket ?? throw new ArgumentNullException(nameof(ticket)));

    public void RemoveTicket(Ticket ticket)
        => _tickets.Remove(ticket ?? throw new ArgumentNullException(nameof(ticket)));
}
