using Cheese.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Cheese.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Cauliflower cheese",
                Price = 150000,
                Description = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Asperiores, recusandae suscipit. Eius porro vitae nihil? Velit quaerat architecto at labore voluptatum veritatis exercitationem quis itaque.",
                ImageUrl = "https://chandraperdana.blob.core.windows.net/cheese/img1.jpg",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Bombay chilli cheese toastie",
                Price = 139900,
                Description = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Asperiores, recusandae suscipit. Eius porro vitae nihil? Velit quaerat architecto at labore voluptatum veritatis exercitationem quis itaque.",
                ImageUrl = "https://chandraperdana.blob.core.windows.net/cheese/img2.jpg",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Potato and pickle dippers",
                Price = 109900,
                Description = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Asperiores, recusandae suscipit. Eius porro vitae nihil? Velit quaerat architecto at labore voluptatum veritatis exercitationem quis itaque.",
                ImageUrl = "https://chandraperdana.blob.core.windows.net/cheese/img3.jpg",
                CategoryName = "Dessert"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Cheese straws",
                Price = 150000,
                Description = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Asperiores, recusandae suscipit. Eius porro vitae nihil? Velit quaerat architecto at labore voluptatum veritatis exercitationem quis itaque.",
                ImageUrl = "https://chandraperdana.blob.core.windows.net/cheese/img4.jpg",
                CategoryName = "Entree"
            });
        }
    }
}
