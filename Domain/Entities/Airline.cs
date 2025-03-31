using Domain.Common;

namespace Domain.Entities;

public class Airline : Base
{
    public required string Name { get; init; }
    public required string Country { get; init; }

    private readonly List<Aircraft> _aircrafts = [];
    public IReadOnlyCollection<Aircraft> Aircrafts => _aircrafts.AsReadOnly();

    private Airline() { }

    public Airline(string name, string country)
    {
        Id = Guid.NewGuid();
        Name = name;
        Country = country;
    }

    public void AddAircraft(Aircraft aircraft)
        => _aircrafts.Add(aircraft ?? throw new ArgumentNullException(nameof(aircraft)));

    public void RemoveAircraft(Aircraft aircraft)
        => _aircrafts.Remove(aircraft ?? throw new ArgumentNullException(nameof(aircraft)));
}
