﻿using Domain.Common;

namespace Domain.Entities;

public class Passenger(Guid id, string fullName, DateOnly dateOfBirth, string passport) : BaseEntity<Guid>(id)
{
    public required string FullName { get; init; } = fullName;
    public required DateOnly DateOfBirth { get; init; } = dateOfBirth;
    public required string Passport { get; init; } = passport;

    private readonly List<Ticket> _tickets = [];
    public IReadOnlyCollection<Ticket> Tickets => _tickets.AsReadOnly();
}
