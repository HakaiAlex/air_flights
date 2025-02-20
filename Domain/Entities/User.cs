using Domain.Common;

namespace Domain.Entities;

public class User : Base
{
    public string Email { get; private set; } = string.Empty;
    public string Password { get; private set; } = string.Empty;
    public string UserName { get; private set; } = string.Empty;
    public string PhoneNumber { get; private set; } = string.Empty;
    public string Role { get; private set; } = string.Empty;
    public DateTime CreatedAt { get; private set; } = default;

    private readonly List<Booking> _bookings = [];
    public IReadOnlyCollection<Booking> Bookings => _bookings.AsReadOnly();

    private User() { }

    public User(string email, string password, string userName, string phoneNumber, string role)
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
