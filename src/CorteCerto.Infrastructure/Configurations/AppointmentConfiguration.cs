using CorteCerto.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CorteCerto.Infrastructure.Configurations;

public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
{
    public void Configure(EntityTypeBuilder<Appointment> builder)
    {
        builder.ToTable("Appointments");

        builder.HasKey(a => a.Id);

        builder.Property(a => a.Date)
            .IsRequired();
        builder.Property(a => a.ResponseDeadline)
            .IsRequired();
        builder.Property(a => a.Status)
            .HasConversion<string>()
            .IsRequired();

        builder.HasOne(a => a.Customer)
            .WithMany(c => c.Appointments)
            .HasForeignKey("CustomerId")
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(a => a.Barber)
            .WithMany(b => b.Appointments)
            .HasForeignKey("BarberId")
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(a => a.Service)
            .WithMany(s => s.Appointments)
            .HasForeignKey("ServiceId")
            .OnDelete(DeleteBehavior.Restrict);
    }
}
