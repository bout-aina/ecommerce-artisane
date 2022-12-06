using Artisanaux.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Artisanaux.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext:DbContext
    { //ctor double tabulation
        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                ProductName = "Tapis",
                Price= 123,
                CategoryName = "categorie 1",
                ImageURL = "https://artisana.blob.core.windows.net/artisana/1.jpg"

            }
                ) ;
           modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                ProductName = "Sacs",
                Price= 15,
                CategoryName = "categorie 2",
                ImageURL = "https://artisana.blob.core.windows.net/artisana/2.jpg"

           }
                ) ;
           modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                ProductName = "Couvre",
                Price= 123,
                CategoryName = "categorie 3",
                ImageURL = "https://artisana.blob.core.windows.net/artisana/3.jpeg"

           }
                ) ;
           modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                ProductName = "Vers",
                Price= 123,
                CategoryName = "categorie 4",
                ImageURL = "https://artisana.blob.core.windows.net/artisana/4.jpg"

           }
                ) ;
           
            
        }
    }
}
