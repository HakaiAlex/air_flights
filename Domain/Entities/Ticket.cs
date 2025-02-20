using Domain.Common;

namespace Domain.Entities;

public class Ticket : Base
{
    public int SeatNumber { get; private set; }
    public decimal Price { get; private set; } = default;
    public bool IsActive { get; private set; } = default;
    public int FlightId { get; private set; }

    public Passenger? Passenger { get; private set; }
    public Flight? Flight { get; private set; }

    public int BookingId { get; private set; }
    public Booking? Booking { get; private set; } 

    private Ticket() { }

    public Ticket(int seatNumber, decimal price, bool isActive, Passenger passenger, Flight flight)
    {
        Id = Guid.NewGuid();
        SeatNumber = seatNumber;
        Price = price;
        IsActive = isActive;
        Passenger = passenger;
        Flight = flight;
    }
}
