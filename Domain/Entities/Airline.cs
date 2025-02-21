using Domain.Common;

namespace Domain.Entities;

public class Airline : Base
{
    public string? Name { get; private set; }
    public string? Country { get; private set; }

    private readonly List<Aircraft?> _aircrafts = [];
    public IReadOnlyCollection<Aircraft?> Aircrafts => _aircrafts.AsReadOnly();

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
