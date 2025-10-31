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

         // Many-to-many Person <-> Role
         builder.HasMany(p => p.Roles)
            .WithMany(r => r.Peoples)
            .UsingEntity<Dictionary<string, object>>(
                "PersonRoles",
                j => j.HasOne<Role>()
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .HasConstraintName("FK_PersonRoles_RoleId")
                    .OnDelete(DeleteBehavior.Cascade),
                j => j.HasOne<Person>()
                    .WithMany()
                    .HasForeignKey("PersonId")
                    .HasConstraintName("FK_PersonRoles_PersonId")
                    .OnDelete(DeleteBehavior.Cascade),
                j =>
                {
                    j.HasKey("PersonId", "RoleId");
                    j.ToTable("PersonRoles");
                }
            );
     }
}
