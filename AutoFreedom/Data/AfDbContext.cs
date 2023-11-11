using AutoFreedom.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoFreedom.Data
{
    public class AfDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public AfDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost;Database=AutoFreedom;Trusted_Connection=True;TrustServerCertificate=true;MultipleActiveResultSets=true");
        }

        public DbSet<Store> Stores { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);

        }

    }
}
