using Domain.Common;

namespace Domain.Entities;

public class User(Guid id, string email, string password, 
    string userName, string phoneNumber, string role = "User") : BaseEntity<Guid>(entityId: id)
{
    public required string Email { get; init; } = email;
    public required string Password { get; init; } = password;
    public required string UserName { get; init; } = userName;
    public required string PhoneNumber { get; init; } = phoneNumber;
    public required string Role { get; init; } = role;
    public DateTime CreatedAt { get; private set; } = DateTime.Now;

    private readonly List<Booking> _bookings = [];
    public IReadOnlyCollection<Booking> Bookings => _bookings.AsReadOnly();
}
