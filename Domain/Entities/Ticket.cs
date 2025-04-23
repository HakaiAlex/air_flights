using Domain.Common;

namespace Domain.Entities;

public class Ticket(Guid id, int seatNumber, decimal price, bool isActive) : BaseEntity<Guid>(id)
{
    public required int SeatNumber { get; init; } = seatNumber;
    public required decimal Price { get; init; } = price;
    public required bool IsActive { get; init; } = isActive;

    public Guid BookingId { get; private set; }
    public Guid PassengerId { get; private set; }
    public Guid FlightId { get; private set; }
    public Guid PaymentId { get; private set; }

    public Booking Booking { get; private set; } = null!;
    public Passenger Passenger { get; private set; } = null!;
    public Flight Flight { get; private set; } = null!;
    public Payment Payment { get; private set; } = null!;
}
