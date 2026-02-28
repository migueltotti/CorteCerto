using CorteCerto.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CorteCerto.Infrastructure.Configurations;

public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
     public void Configure(EntityTypeBuilder<Country> builder)
     {
         builder.ToTable("Countries");

         builder.HasKey(c => c.Id);

         builder.Property(c => c.Id)
            .ValueGeneratedOnAdd();
         builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(100);

         // Relation: Country -> States (one country has many states)
         builder.HasMany(c => c.States)
            .WithOne(s => s.Country)
            .HasForeignKey(s => s.CountryId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

         // Ensure country names are unique
         builder.HasIndex(c => c.Name)
            .IsUnique();
     }
}
