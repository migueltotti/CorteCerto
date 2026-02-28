using CorteCerto.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Infrastructure.Configurations;

public class CityConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.ToTable("Cities");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
               .ValueGeneratedOnAdd();
        builder.Property(c => c.Name)
               .IsRequired()
               .HasMaxLength(100);

        // Relation: City -> State (many cities belong to one state)
        // Use a shadow FK "StateId" because City doesn't expose a StateId property in the entity signature
        builder.HasOne(c => c.State)
               .WithMany(s => s.Cities)
               .HasForeignKey(c => c.StateId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);

        // Relation: City -> Addresses (one city has many addresses)
        // Use a shadow FK "CityId" because Address doesn't expose a CityId property in the entity signature
        builder.HasMany(c => c.Addresses)
               .WithOne(a => a.City)
               .HasForeignKey(a => a.CityId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Cascade);

        // Prevent duplicate city names within the same state
        builder.HasIndex("StateId", "Name")
               .IsUnique();
    }
}
