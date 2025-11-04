using CorteCerto.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CorteCerto.Infrastructure.Configurations;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
     public void Configure(EntityTypeBuilder<Person> builder)
     {
        builder.ToTable("People");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(200);
        builder.Property(p => p.Email)
            .IsRequired()
            .HasMaxLength(200);
        builder.Property(p => p.PhoneNumber)
            .IsRequired()
            .HasMaxLength(11);
        builder.Property(p => p.PasswordHash)
           .IsRequired()
           .HasMaxLength(200);
     }
}
