using Artisanaux.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Artisanaux.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext:DbContext
    { //ctor double tabulation
        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
