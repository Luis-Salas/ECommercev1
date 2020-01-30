using Microsoft.EntityFrameworkCore;

namespace EcommerceApp.Models
{
    public class HomeContext : DbContext
    {
        public HomeContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductStyle>().HasKey(sc => new { sc.ProductId, sc.StyleId });
            modelBuilder.Entity<ProductOrders>().HasKey(sc => new { sc.ProductId, sc.OrderId });

        }
    
        public DbSet<User> Users {get;set;}

        public DbSet<Page> Pages {get;set;}

        public DbSet<Product> Products {get;set;}

        public DbSet<Style> Styles {get;set;}

        public DbSet<Design> Designs {get;set;}
        public DbSet<ProductStyle> ProductStyles {get;set;}
        public DbSet<Order> Orders {get;set;}
        public DbSet<ProductOrders> ProductOrders  {get;set;}


    }
}