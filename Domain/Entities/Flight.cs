﻿using Domain.Common;

namespace Domain.Entities;

public class Flight : Base
{
    public required DateTime Departure { get; init; }
    public required DateTime Arrival { get; init; }

    public Guid FromAirportId { get; private set; }
    public Guid ToAirportId { get; private set; }
    public Guid AircraftId { get; private set; }

    public Airport FromAirport { get; private set; } = null!;
    public Airport ToAirport { get; private set; } = null!;
    public Aircraft Aircraft { get; private set; } = null!;

    private readonly List<Ticket> _tickets = [];
    public IReadOnlyCollection<Ticket> Tickets => _tickets.AsReadOnly();

    private Flight() { }

    public Flight(DateTime departure, DateTime arrival)
    {
        Id = Guid.NewGuid();
        Departure = departure;
        Arrival = arrival;
    }

    public void AddTicket(Ticket ticket) 
        => _tickets.Add(ticket ?? throw new ArgumentNullException(nameof(ticket)));

    public void RemoveTicket(Ticket ticket)
        => _tickets.Remove(ticket ?? throw new ArgumentNullException(nameof(ticket)));
}
