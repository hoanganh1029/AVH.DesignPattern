using AVH.Observer.Models;
using Microsoft.EntityFrameworkCore;

namespace AVH.Observer.Data;

public class AppDbContext : DbContext
{
    // Define DbSets (tables)
    public DbSet<Customer> Customers { get; set; }

    public DbSet<Product> Products { get; set; }

    // Configure the context to use an InMemory database
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("AVHTestDb"); // Use InMemory database named 'TestDb'
    }
}
