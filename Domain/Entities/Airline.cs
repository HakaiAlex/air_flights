using Domain.Common;

namespace Domain.Entities;

public class Airline(Guid id, string name, string country) : BaseEntity<Guid>(id)
{
    public required string Name { get; init; } = name;
    public required string Country { get; init; } = country;


    private readonly List<Aircraft> _aircrafts = [];
    public IReadOnlyCollection<Aircraft> Aircrafts => _aircrafts.AsReadOnly();
}
