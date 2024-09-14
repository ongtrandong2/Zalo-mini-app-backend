using Microsoft.EntityFrameworkCore;
using Zalo_mini_app_backend.Models;

namespace Zalo_mini_app_backend
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Product>().ToTable("Products");

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "ABC", PhoneNumber = "0983827050", AvtUrl = "https://placehold.co/100x100" },
                new User { Id = 2, Name = "DEF", PhoneNumber = "0983827051", AvtUrl = "https://placehold.co/100x100" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Product 1", Code = "P001", Price = 100m, ImageUrl = "https://placehold.co/100x100" },
                new Product { Id = 2, Name = "Product 2", Code = "P002", Price = 150m, ImageUrl = "https://placehold.co/100x100" },
                new Product { Id = 3, Name = "Product 3", Code = "P003", Price = 200m, ImageUrl = "https://placehold.co/100x100" },
                new Product { Id = 4, Name = "Product 4", Code = "P004", Price = 250m, ImageUrl = "https://placehold.co/100x100" }
            );
        }
    }
}
