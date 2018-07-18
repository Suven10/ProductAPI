using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    GuProductId = table.Column<string>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    ProdStatus = table.Column<int>(nullable: false),
                    UnitQty = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    Taxable = table.Column<int>(nullable: false),
                    GuTaxGrpId = table.Column<string>(nullable: true),
                    Sku = table.Column<int>(nullable: false),
                    CostPrice = table.Column<string>(nullable: true),
                    MinStock = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.GuProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
