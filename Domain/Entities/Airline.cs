using Domain.Common;

namespace Domain.Entities;

public class Airline : Base
{
    public string? Name { get; private set; }
    public string? Country { get; private set; }

    private readonly List<Airline?> _airlines = [];
    public IReadOnlyCollection<Airline?> Airlines => _airlines.AsReadOnly();

    private Airline() { }

    public Airline(string name, string country)
    {
        Id = Guid.NewGuid();
        Name = name;
        Country = country;
    }

    public void AddAirline(Airline airline)
        => _airlines.Add(airline ?? throw new ArgumentNullException(nameof(airline)));

    public void RemoveAirline(Airline airline)
        => _airlines.Remove(airline ?? throw new ArgumentNullException(nameof(airline)));
}
