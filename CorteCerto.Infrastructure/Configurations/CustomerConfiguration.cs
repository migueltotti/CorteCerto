using CorteCerto.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CorteCerto.Infrastructure.Configurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("Customers");

        builder.Property(c => c.PromotionPoints)
            .IsRequired();

        builder.HasMany(c => c.Appointments)
            .WithOne(a => a.Customer)
            .HasForeignKey("CustomerId");
    }
}
