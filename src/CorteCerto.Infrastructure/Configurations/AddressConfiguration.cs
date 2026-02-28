using CorteCerto.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CorteCerto.Infrastructure.Configurations;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("Addresses");

        builder.HasKey(a => a.Id);

        builder.Property(a => a.Street)
               .IsRequired()
               .HasMaxLength(200);
        builder.Property(a => a.Number)
            .IsRequired();
        builder.Property(a => a.ZipCode)
               .IsRequired()
               .HasMaxLength(8);

        builder.HasOne(a => a.City)
               .WithMany(c => c.Addresses)
               .HasForeignKey(a => a.CityId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);
    }
}
