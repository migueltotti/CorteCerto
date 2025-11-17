using CorteCerto.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CorteCerto.Infrastructure.Configurations;

public class ServiceConfiguration : IEntityTypeConfiguration<Service>
{
    public void Configure(EntityTypeBuilder<Service> builder)
    {
        builder.ToTable("Services");

        builder.HasKey(s => s.Id);

        builder.Property(s => s.Id)
            .ValueGeneratedOnAdd();
        builder.Property(s => s.Name)
            .IsRequired()
            .HasMaxLength(200);
        builder.Property(s => s.Description)
            .HasMaxLength(1000);
        builder.Property(s => s.Price)
            .IsRequired()
            .HasPrecision(10, 2);
        builder.Property(s => s.Duration)
            .IsRequired();

        builder.HasOne(s => s.Barber)
            .WithMany(b => b.Services)
            .HasForeignKey("BarberId")
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(s => s.Appointments)
            .WithOne(a => a.Service)
            .HasForeignKey("ServiceId");
    }
}
