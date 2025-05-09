﻿using Domain.Common;

namespace Domain.Entities;

public class Payment(Guid id, decimal amount, string status, string paymentMethod) : BaseEntity<Guid>(id)
{
    public required decimal Amount { get; init; } = amount;
    public required string Status { get; init; } = status;
    public required string PaymentMethod { get; init; } = paymentMethod;
    public required DateTime CreatedAt { get; init; } = DateTime.Now;

    private readonly List<Ticket> _tickets = [];
    public IReadOnlyCollection<Ticket> Tickets => _tickets.AsReadOnly();
}
