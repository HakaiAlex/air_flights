using Domain.Common;

namespace Domain.Entities;

public class Airport(Guid id, string name, string code, string city, string country) : BaseEntity<Guid>(id)
{
    public required string Name { get; init; } = name;
    public required string Code { get; init; } = code;
    public required string City { get; init; } = city;
    public required string Country { get; init; } = country;

    private readonly List<Flight> _departing = [];
    // Рейсы, прибывающие в этот аэропорт
    private readonly List<Flight> _arriving = [];

    public IReadOnlyCollection<Flight> Departures => _departing.AsReadOnly();
    public IReadOnlyCollection<Flight> Arrivals => _arriving.AsReadOnly();
}
