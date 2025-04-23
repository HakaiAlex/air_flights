using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.EntityId);
        builder.HasIndex(u => u.EntityId).IsUnique();

        builder.Property(u => u.UserName)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(u => u.Password)
            .IsRequired();
        builder.Property(u => u.Role)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasMany(u => u.Bookings)
            .WithOne(b => b.User)
            .HasForeignKey(b => b.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
