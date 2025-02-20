using Domain.Common;

namespace Domain.Entities;

public class Aircraft : Base
{
    public string? Model { get; private set; }
    public int Capacity { get; private set; }
    
    public Guid? AirlineId { get; private set; }
    public Airline? Airline { get; private set; }

    private readonly List<Flight?> _flights = [];
    public IReadOnlyCollection<Flight?> Flights => _flights.AsReadOnly();

    private Aircraft() { }

    public Aircraft(string model,  int capacity)
    {
        Id = Guid.NewGuid();
        Model = model;
        Capacity = capacity;
    }

    public void AddTicket(Flight flight)
        => _flights.Add(flight ?? throw new ArgumentNullException(nameof(flight)));

    public void RemoveTicket(Flight flight)
        => _flights.Remove(flight ?? throw new ArgumentNullException(nameof(flight)));
}
