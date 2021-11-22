using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations.Data
{
    public partial class InitialMain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInfos_Products_ProductId",
                table: "ProductInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_Description_ProductInfos_ProductInfoId",
                table: "Description");

            migrationBuilder.DropForeignKey(
                name: "FK_Description_ProductInfos_ProductInfoId1",
                table: "Description");

            migrationBuilder.DropTable(
                name: "CartLines");

            migrationBuilder.DropTable(
                name: "ProductIngredientsTableRow");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "ProductInfos");

            migrationBuilder.DropTable(
                name: "Description");
        }
    }
}
