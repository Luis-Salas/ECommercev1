namespace EcommerceApp.Models
{
    public class HomeContext
    {
        public HomeContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users {get;set;}

        public DbSet<Page> Pages {get;set;}

        public DbSet<Product> Products {get;set;}

        public DbSet<Style> Styles {get;set;}

        public DbSet<Category> Categories {get;set;}

        public DbSet<SubCategory> SubCategories {get;set;}

    }
}