using Domain.Common;

namespace Domain.Entities;

public class Airport : Base
{
    public required string Name { get; init; }
    public required string Code { get; init; }
    public required string City { get; init; }
    public required string Country { get; init; }

    private readonly List<Flight> _flights = [];
    public IReadOnlyCollection<Flight> Flights => _flights.AsReadOnly();

    private Airport() { }

    public Airport(string name, string code, string city, string country)
    {
        Id = Guid.NewGuid();
        Name = name;
        Code = code;
        City = city;
        Country = country;
    }

    public void AddFlight(Flight flight)
        => _flights.Add(flight ?? throw new ArgumentNullException(nameof(flight)));

    public void RemoveFlights(Flight flight)
        => _flights.Remove(flight ?? throw new ArgumentNullException(nameof(flight)));
}
