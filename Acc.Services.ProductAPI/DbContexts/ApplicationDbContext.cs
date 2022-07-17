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
                Name = "Intel Core i9 12900F",
                Price = 580,
                Description = "5.2 GHz, 30MB, BOX, LGA1700, Alder Lake",
                ImageUrl = "https://microdev.blob.core.windows.net/acc/LD0005914951_1.png",
                CategoryName = "CPU"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "AMD Ryzen 9 5900X",
                Price = 500,
                Description = "Vermeer 3.7 GHz, 12 Cores/24 Threads, No GPU, AM4 (100-000000061), oem ",
                ImageUrl = "https://microdev.blob.core.windows.net/acc/6158112776.jpg",
                CategoryName = "CPU"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "AMD Ryzen 9 5950X",
                Price = 700,
                Description = "Vermeer 3.4 GHz, 16 Cores/32 Threads, No GPU, AM4 (100-000000061), oem ",
                ImageUrl = "https://microdev.blob.core.windows.net/acc/6158112776.jpg",
                CategoryName = "CPU"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Kingston DDR5 16GB",
                Price = 165,
                Description = "5600Mhz Fury (KF556C40BB-16)",
                ImageUrl = "https://microdev.blob.core.windows.net/acc/Fury.jpg",
                CategoryName = "RAM"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Crucial  DDR4  16GB",
                Price = 53,
                Description = "2666Mhz ",
                ImageUrl = "https://microdev.blob.core.windows.net/acc/crucial.jpg",
                CategoryName = "RAM"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Name = "Aorus DDR4 16GB",
                Price = 140,
                Description = "4400Mhz (8*2) RGB Memory (GP-ARS16G44)",
                ImageUrl = "https://microdev.blob.core.windows.net/acc/operativnaya_pamyat_gigabyte_ddr4_16gb_2x8gb_4400mhz_pc_35200_aorus_rgb_led_gp_ars16g44__1460258_1.jpg",
                CategoryName = "RAM"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 7,
                Name = "Palit 12GB GeForce RTX3080Ti",
                Price = 1300,
                Description = "GAMEROCK PRO GDDR6 320bit 3 - DP HDMI LHR",
                ImageUrl = "https://microdev.blob.core.windows.net/acc/palit.jpg",
                CategoryName = "GPU"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 8,
                Name = "MSI 12GB GeForce RTX3080Ti",
                Price = 1300,
                Description = "Gaming X Trio LHR",
                ImageUrl = "https://microdev.blob.core.windows.net/acc/02-msi-geforce-rtx-3070-gaming-x-trio.jpg",
                CategoryName = "GPU"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 9,
                Name = "Gigabyte-12GB GeForce RTX 3080Ti",
                Price = 1300,
                Description = "VISION OC GV-N308TVISION OC-12GD",
                ImageUrl = "https://microdev.blob.core.windows.net/acc/gigabyte.jpg",
                CategoryName = "GPU"
            });
        }
    }
    
}
