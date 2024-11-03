using LaptopStoreSharedLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace LaptopStoreServer.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; } = default!;
        public DbSet<Category> Categories { get; set; } = default!;

    }

    public delegate void OnModelCreating(ModelBuilder modelBuilder);
}
