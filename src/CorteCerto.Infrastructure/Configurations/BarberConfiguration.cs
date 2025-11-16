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

        builder.OwnsMany(b => b.Availabilities, availabilitiesBuilder =>
        {
            availabilitiesBuilder.WithOwner().HasForeignKey("BarberId");

            availabilitiesBuilder.ToTable("BarberAvailabilities");

            availabilitiesBuilder.HasKey("BarberId", "DayOfWeek");

            availabilitiesBuilder.Property(b => b.DayOfWeek)
                .IsRequired()
                .HasConversion<string>();
            availabilitiesBuilder.Property(b => b.StartTime)
                .IsRequired();
            availabilitiesBuilder.Property(b => b.EndTime)
                .IsRequired();
        });

        //builder.HasMany(b => b.Availabilities)
        //    .WithOne()
        //    .HasForeignKey("BarberId")
        //    .OnDelete(DeleteBehavior.ClientCascade);

        builder.HasMany(b => b.Services)
            .WithOne(s => s.Barber)
            .HasForeignKey("BarberId")
            .OnDelete(DeleteBehavior.ClientCascade);

        builder.HasMany(b => b.Appointments)
            .WithOne(a => a.Barber)
            .HasForeignKey("BarberId");
    }
}
