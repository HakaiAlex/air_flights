using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class BookingConfiguratoin : IEntityTypeConfiguration<Booking>
{
    public void Configure(EntityTypeBuilder<Booking> builder)
    {
        builder.HasKey(b => b.EntityId);
        builder.HasIndex(b => b.EntityId).IsUnique();

        builder.Property(b => b.FullName)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(b => b.Status)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasMany(b => b.Tickets)
            .WithOne(t => t.Booking)
            .HasForeignKey(t => t.BookingId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
