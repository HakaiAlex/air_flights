using Domain.Common;

namespace Domain.Entities;

public class Ticket : Base
{
    public required int SeatNumber { get; init; }
    public required decimal Price { get; init; }
    public required bool IsActive { get; init; }

    public Guid BookingId { get; private set; }
    public Guid PassengerId { get; private set; }
    public Guid FlightId { get; private set; }
    public Guid PaymentId { get; private set; }

    public Booking Booking { get; private set; } = null!;
    public Passenger Passenger { get; private set; } = null!;
    public Flight Flight { get; private set; } = null!;
    public Payment Payment { get; private set; } = null!;

    private Ticket() { }

    public Ticket(int seatNumber, decimal price, bool isActive)
    {
        Id = Guid.NewGuid();
        SeatNumber = seatNumber;
        Price = price;
        IsActive = isActive;
    }
}
