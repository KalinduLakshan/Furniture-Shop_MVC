using Microsoft.EntityFrameworkCore;

namespace FurnitureShop.Models
{
    public class FurnitureShopContext : DbContext
    {
        public FurnitureShopContext(DbContextOptions<FurnitureShopContext> options)
        : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderLine> OrderLines { get; set; } = null!;
        public DbSet<ProductLine> ProductLines { get; set; } = null!;
    }
}
