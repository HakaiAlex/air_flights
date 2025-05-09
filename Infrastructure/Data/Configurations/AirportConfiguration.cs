﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class AirportConfiguration : IEntityTypeConfiguration<Airport>
{
    public void Configure(EntityTypeBuilder<Airport> builder)
    {
        builder.HasKey(a => a.Id);
        builder.HasIndex(a => a.Id).IsUnique();

        builder.Property(a => a.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(a => a.Code)
            .IsRequired()
            .HasMaxLength(10);

        builder.Property(a => a.City)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(a => a.Country)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasMany(a => a.Departures)
            .WithOne(f => f.FromAirport)
            .HasForeignKey(f => f.FromAirportId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(a => a.Arrivals)
            .WithOne(f => f.ToAirport)
            .HasForeignKey(f => f.ToAirportId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
