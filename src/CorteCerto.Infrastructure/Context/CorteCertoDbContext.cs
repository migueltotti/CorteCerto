using CorteCerto.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Infrastructure.Context;

public class CorteCertoDbContext : DbContext
{
    public CorteCertoDbContext(/*DbContextOptions<CorteCertoDbContext> options*/) : base()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("User ID=developer;Password=123456789;Server=localhost;Port=5432;Database=corteCertoDb;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CorteCertoDbContext).Assembly);
    }

    public DbSet<Address> Addresses { get; set; }
    public DbSet<Appointment> Appointments{ get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<State> States { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Person> People { get; set; }   
    public DbSet<Barber> Barbers { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Service> Services { get; set; }
}
