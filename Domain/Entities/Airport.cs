using Domain.Common;

namespace Domain.Entities;

public class Airport : Base
{
    public string? Name { get; private set; }
    public string? Code { get; private set; }   
    public string? City { get; private set; }
    public string? Country { get; private set; }

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
