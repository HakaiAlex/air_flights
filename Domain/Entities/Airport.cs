using Domain.Common;

namespace Domain.Entities;

public class Airport(Guid id, string name, string code, string city, string country) : BaseEntity<Guid>(id)
{
    public required string Name { get; init; } = name;
    public required string Code { get; init; } = code;
    public required string City { get; init; } = city;
    public required string Country { get; init; } = country;

    private readonly List<Flight> _flights = [];
    public IReadOnlyCollection<Flight> Flights => _flights.AsReadOnly();

    public void AddFlight(Flight flight)
        => _flights.Add(flight ?? throw new ArgumentNullException(nameof(flight)));

    public void RemoveFlights(Flight flight)
        => _flights.Remove(flight ?? throw new ArgumentNullException(nameof(flight)));
}
