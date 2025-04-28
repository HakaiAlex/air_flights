using Domain.Common;

namespace Domain.Entities;

public class Aircraft(Guid id, string model, int capacity) : BaseEntity<Guid>(id)
{
    public required string Model { get; init; } = model;
    public required int Capacity { get; init; } = capacity;

    public Guid AirlineId { get; private set; }
    public Airline Airline { get; private set; } = null!;

    private readonly List<Flight> _flights = [];
    public IReadOnlyCollection<Flight> Flights => _flights.AsReadOnly();
}
