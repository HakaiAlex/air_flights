using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class AirlineConfiguration : IEntityTypeConfiguration<Airline>
{
    public void Configure(EntityTypeBuilder<Airline> builder)
    {
        builder.HasKey(a => a.Id);
        builder.HasIndex(a => a.Id).IsUnique();

        builder.Property(a => a.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(a => a.Country)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasMany(a => a.Aircrafts)
            .WithOne(ac => ac.Airline)
            .HasForeignKey(ac => ac.AirlineId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
