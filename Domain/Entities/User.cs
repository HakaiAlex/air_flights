using Domain.Common;

namespace Domain.Entities;

public class User : Base
{
    public required string Email { get; init; }
    public required string Password { get; init; }
    public required string UserName { get; init; }
    public required string PhoneNumber { get; init; }
    public required  string Role { get; init; }
    public DateTime CreatedAt { get; private set; }

    private readonly List<Booking> _bookings = [];
    public IReadOnlyCollection<Booking> Bookings => _bookings.AsReadOnly();

    private User() { }

    public User(string email, string password, string userName, string phoneNumber, string role = "User")
    {
        Id = Guid.NewGuid();
        Email = email;
        Password = password;
        UserName = userName;
        PhoneNumber = phoneNumber;
        Role = role;
        CreatedAt = DateTime.Now;
    }

    public void AddBooking(Booking booking)
        => _bookings.Add(booking ?? throw new ArgumentNullException(nameof(booking)));

    public void RemoveBooking(Booking booking)
        => _bookings.Remove(booking ?? throw new ArgumentNullException(nameof(booking)));
}
