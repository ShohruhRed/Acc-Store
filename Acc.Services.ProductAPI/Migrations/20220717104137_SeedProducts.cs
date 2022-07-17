using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acc.Services.ProductAPI.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "CPU", "5.2 GHz, 30MB, BOX, LGA1700, Alder Lake", "https://microdev.blob.core.windows.net/acc/LD0005914951_1.png", "Intel Core i9 12900F", 580.0 },
                    { 2, "CPU", "Vermeer 3.7 GHz, 12 Cores/24 Threads, No GPU, AM4 (100-000000061), oem ", "https://microdev.blob.core.windows.net/acc/6158112776.jpg", "AMD Ryzen 9 5900X", 500.0 },
                    { 3, "CPU", "Vermeer 3.4 GHz, 16 Cores/32 Threads, No GPU, AM4 (100-000000061), oem ", "https://microdev.blob.core.windows.net/acc/6158112776.jpg", "AMD Ryzen 9 5950X", 700.0 },
                    { 4, "RAM", "5600Mhz Fury (KF556C40BB-16)", "https://microdev.blob.core.windows.net/acc/Fury.jpg", "Kingston DDR5 16GB", 165.0 },
                    { 5, "RAM", "2666Mhz ", "https://microdev.blob.core.windows.net/acc/crucial.jpg", "Crucial  DDR4  16GB", 53.0 },
                    { 6, "RAM", "4400Mhz (8*2) RGB Memory (GP-ARS16G44)", "https://microdev.blob.core.windows.net/acc/operativnaya_pamyat_gigabyte_ddr4_16gb_2x8gb_4400mhz_pc_35200_aorus_rgb_led_gp_ars16g44__1460258_1.jpg", "Aorus DDR4 16GB", 140.0 },
                    { 7, "GPU", "GAMEROCK PRO GDDR6 320bit 3 - DP HDMI LHR", "https://microdev.blob.core.windows.net/acc/palit.jpg", "Palit 12GB GeForce RTX3080Ti", 1300.0 },
                    { 8, "GPU", "Gaming X Trio LHR", "https://microdev.blob.core.windows.net/acc/02-msi-geforce-rtx-3070-gaming-x-trio.jpg", "MSI 12GB GeForce RTX3080Ti", 1300.0 },
                    { 9, "GPU", "VISION OC GV-N308TVISION OC-12GD", "https://microdev.blob.core.windows.net/acc/gigabyte.jpg", "Gigabyte-12GB GeForce RTX 3080Ti", 1300.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);
        }
    }
}
