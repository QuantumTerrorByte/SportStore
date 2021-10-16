using Microsoft.EntityFrameworkCore.Migrations;

namespace SportStore.Migrations
{
    public partial class InfoProdId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInfo_Products_ProductId",
                table: "ProductInfo");

            migrationBuilder.AlterColumn<long>(
                name: "ProductId",
                table: "ProductInfo",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInfo_Products_ProductId",
                table: "ProductInfo",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInfo_Products_ProductId",
                table: "ProductInfo");

            migrationBuilder.AlterColumn<long>(
                name: "ProductId",
                table: "ProductInfo",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInfo_Products_ProductId",
                table: "ProductInfo",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
