using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class RenameLines : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartLines_Carts_CartId",
                table: "CartLines");

            migrationBuilder.DropForeignKey(
                name: "FK_CartLines_Products_ProductId",
                table: "CartLines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartLines",
                table: "CartLines");

            migrationBuilder.RenameTable(
                name: "CartLines",
                newName: "ProductLines");

            migrationBuilder.RenameIndex(
                name: "IX_CartLines_ProductId",
                table: "ProductLines",
                newName: "IX_ProductLines_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_CartLines_CartId",
                table: "ProductLines",
                newName: "IX_ProductLines_CartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductLines",
                table: "ProductLines",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLines_Carts_CartId",
                table: "ProductLines",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLines_Products_ProductId",
                table: "ProductLines",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductLines_Carts_CartId",
                table: "ProductLines");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductLines_Products_ProductId",
                table: "ProductLines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductLines",
                table: "ProductLines");

            migrationBuilder.RenameTable(
                name: "ProductLines",
                newName: "CartLines");

            migrationBuilder.RenameIndex(
                name: "IX_ProductLines_ProductId",
                table: "CartLines",
                newName: "IX_CartLines_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductLines_CartId",
                table: "CartLines",
                newName: "IX_CartLines_CartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartLines",
                table: "CartLines",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartLines_Carts_CartId",
                table: "CartLines",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartLines_Products_ProductId",
                table: "CartLines",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
