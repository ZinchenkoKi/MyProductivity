using Microsoft.EntityFrameworkCore;

namespace MyProductivity.Entity
{
    internal class DataContext : DbContext
    {
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Applications> Applications { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ProductivityDB;Username=postgres;Password=1234567");
        }
    }
}
