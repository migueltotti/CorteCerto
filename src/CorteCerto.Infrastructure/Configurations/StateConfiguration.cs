using CorteCerto.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CorteCerto.Infrastructure.Configurations;

public class StateConfiguration : IEntityTypeConfiguration<State>
{
    public void Configure(EntityTypeBuilder<State> builder)
    {
        builder.ToTable("States");

        builder.HasKey(s => s.Id);

        builder.Property(s => s.Id)
            .ValueGeneratedOnAdd();
        builder.Property(s => s.Name)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(s => s.Acronym)
            .IsRequired()
            .HasMaxLength(2);

        // Relation: State -> Country (many states belong to one country)
        builder.HasOne(s => s.Country)
               .WithMany(c => c.States)
               .HasForeignKey("CountryId")
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);

        // Relation: State -> Cities (one state has many cities)
        builder.HasMany(s => s.Cities)
               .WithOne(c => c.State)
               .HasForeignKey("StateId")
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);

        // Prevent duplicate state names within the same country
        builder.HasIndex("CountryId", "Name")
               .IsUnique();
        builder.HasIndex("Name", "Acronym")
               .IsUnique();
    }
}