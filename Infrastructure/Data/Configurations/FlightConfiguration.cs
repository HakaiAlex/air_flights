using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class FlightConfiguration : IEntityTypeConfiguration<Flight>
{
    public void Configure(EntityTypeBuilder<Flight> builder)
    {
        builder.HasKey(f => f.Id);

        builder.Property(f => f.Departure)
            .IsRequired();

        builder.Property(f => f.Arrival)
            .IsRequired();

        builder.HasOne(f => f.FromAirport)
            .WithMany()
            .HasForeignKey(f => f.FromAirportId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(f => f.ToAirport)
            .WithMany()
            .HasForeignKey(f => f.ToAirportId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(f => f.Aircraft)
            .WithMany()
            .HasForeignKey(f => f.AircraftId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(f => f.Tickets)
            .WithOne(t => t.Flight)
            .HasForeignKey(t => t.FlightId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
