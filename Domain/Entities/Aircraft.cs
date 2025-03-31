using Domain.Common;

namespace Domain.Entities;

public class Aircraft : Base
{
    public required string Model { get; init; }
    public required int Capacity { get; init; }
    
    public Guid AirlineId { get; private set; }
    public Airline Airline { get; private set; } = null!;

    private readonly List<Flight> _flights = [];
    public IReadOnlyCollection<Flight> Flights => _flights.AsReadOnly();

    private Aircraft() { }

    public Aircraft(string model, int capacity)
    {
        Id = Guid.NewGuid();
        Model = model;
        Capacity = capacity;
    }

    public void AddFlight(Flight flight)
        => _flights.Add(flight ?? throw new ArgumentNullException(nameof(flight)));

    public void RemoveFlight(Flight flight)
        => _flights.Remove(flight ?? throw new ArgumentNullException(nameof(flight)));
}
