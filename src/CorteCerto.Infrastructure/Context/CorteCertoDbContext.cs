using CorteCerto.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CorteCerto.Infrastructure.Context;

public class CorteCertoDbContext : DbContext
{
    public CorteCertoDbContext(DbContextOptions<CorteCertoDbContext> options) : base(options)
    {
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
