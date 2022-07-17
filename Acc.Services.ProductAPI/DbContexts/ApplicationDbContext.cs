using Acc.Services.ProductAPI.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace Acc.Services.ProductAPI.DbContexts
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
                Name = "Intel Core i9 10900F",
                Price = 390,
                Description = " 5.1 GHz, 16MB, oem, LGA1200, Comet Lake ",
                ImageUrl = "",
                CategoryName = "CPU"
            });
        }
    }
}
