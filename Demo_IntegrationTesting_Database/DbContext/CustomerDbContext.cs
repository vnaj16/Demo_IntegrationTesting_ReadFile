using Demo_IntegrationTesting_Database.Models;
using Microsoft.EntityFrameworkCore;
namespace Demo_IntegrationTesting_Database.DbContext
{
    public class CustomerDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public CustomerDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer() { Id = 1, Debt = 500, FirstName = "Arthur", LastName = "Valladares"}, 
                new Customer() { Id = 2, Debt = 600, FirstName = "Javier", LastName = "Nole" });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
