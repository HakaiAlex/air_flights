using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
{
    public void Configure(EntityTypeBuilder<Passenger> builder)
    {
        builder.HasKey(p => p.EntityId);

        builder.Property(p => p.FullName)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(p => p.Passport)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasMany(p => p.Tickets)
            .WithOne(t => t.Passenger)
            .HasForeignKey(t => t.PassengerId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
