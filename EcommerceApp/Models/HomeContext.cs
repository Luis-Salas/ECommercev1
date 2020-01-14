using Microsoft.EntityFrameworkCore;

namespace EcommerceApp.Models
{
    public class HomeContext : DbContext
    {
        public HomeContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductStyle>().HasKey(sc => new { sc.ProductId, sc.StyleId });
        }
        public DbSet<User> Users {get;set;}

        public DbSet<Page> Pages {get;set;}

        public DbSet<Product> Products {get;set;}

        public DbSet<Style> Styles {get;set;}

        public DbSet<Category> Categories {get;set;}

        public DbSet<SubStyle> SubStyles {get;set;}
        public DbSet<ProductStyle> ProductStyles {get;set;}
    }
}