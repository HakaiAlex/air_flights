using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
{
    public void Configure(EntityTypeBuilder<Ticket> builder)
    {
        builder.HasKey(t => t.Id);
        builder.HasIndex(t => t.Id).IsUnique();

        builder.Property(t => t.SeatNumber)
            .IsRequired();

        builder.Property(t => t.Price)
            .IsRequired()
            .HasPrecision(18, 2);

        builder.Property(t => t.IsActive)
            .IsRequired();

        builder.HasOne(t => t.Booking)
            .WithMany(b => b.Tickets)
            .HasForeignKey(t => t.BookingId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(t => t.Passenger)
            .WithMany(p => p.Tickets)
            .HasForeignKey(t => t.PassengerId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(t => t.Flight)
            .WithMany(f => f.Tickets)
            .HasForeignKey(t => t.FlightId)
            .OnDelete(DeleteBehavior.Cascade);


        builder.HasOne(t => t.Payment)
            .WithMany(p => p.Tickets)
            .HasForeignKey(t => t.PaymentId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
