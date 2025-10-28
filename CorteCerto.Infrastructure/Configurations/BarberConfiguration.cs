using CorteCerto.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CorteCerto.Infrastructure.Configurations;

public class BarberConfiguration : IEntityTypeConfiguration<Barber>
{
    public void Configure(EntityTypeBuilder<Barber> builder)
    {
        builder.ToTable("Barbers");

        builder.Property(b => b.Description)
            .HasMaxLength(1000);
        builder.Property(b => b.PortfolioUrl)
            .HasMaxLength(500);
        builder.Property(b => b.Rating)
            .HasPrecision(2,1);

        builder.HasOne(b => b.Address)
            .WithOne()
            .HasForeignKey<Barber>("AddressId")
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasMany(b => b.Availabilities)
            .WithOne(a => a.Barber)
            .HasForeignKey("BarberId")
            .OnDelete(DeleteBehavior.ClientCascade);

        builder.HasMany(b => b.Services)
            .WithOne(s => s.Barber)
            .HasForeignKey("BarberId")
            .OnDelete(DeleteBehavior.ClientCascade);

        builder.HasMany(b => b.Appointments)
            .WithOne(a => a.Barber)
            .HasForeignKey("BarberId");
    }
}
