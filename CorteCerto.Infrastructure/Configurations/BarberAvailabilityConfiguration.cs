using CorteCerto.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CorteCerto.Infrastructure.Configurations;

public class BarberAvailabilityConfiguration : IEntityTypeConfiguration<BarberAvailability>
{
    public void Configure(EntityTypeBuilder<BarberAvailability> builder)
    {
        builder.ToTable("BarberAvailabilities");

        builder.HasKey(b => b.Id);

        builder.Property(b => b.Id)
            .ValueGeneratedOnAdd();
        builder.Property(b => b.DayOfWeek)
            .IsRequired();
        builder.Property(b => b.StartTime)
            .IsRequired();
        builder.Property(b => b.EndTime)
            .IsRequired();


        builder.HasOne(b => b.Barber)
            .WithMany(b => b.Availabilities)
            .HasForeignKey("BarberId")
            .OnDelete(DeleteBehavior.Cascade);
    }
}
