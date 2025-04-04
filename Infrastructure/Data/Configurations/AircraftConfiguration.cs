using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class AircraftConfiguration : IEntityTypeConfiguration<Aircraft>
{
    public void Configure(EntityTypeBuilder<Aircraft> builder)
    {
        builder.HasKey(a => a.Id);
        builder.HasIndex(a => a.Id).IsUnique();

        builder.Property(a => a.Model)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(a => a.Capacity)
            .IsRequired();

        builder.HasMany(a => a.Flights)
            .WithOne(f => f.Aircraft)
            .HasForeignKey(f => f.AircraftId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
