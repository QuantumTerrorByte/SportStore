using Microsoft.EntityFrameworkCore.Migrations;

namespace SportStore.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartLine_Orders_OrderId",
                table: "CartLine");

            migrationBuilder.DropForeignKey(
                name: "FK_CartLine_Products_ProductId",
                table: "CartLine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartLine",
                table: "CartLine");

            migrationBuilder.RenameTable(
                name: "CartLine",
                newName: "CartLines");

            migrationBuilder.RenameIndex(
                name: "IX_CartLine_ProductId",
                table: "CartLines",
                newName: "IX_CartLines_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_CartLine_OrderId",
                table: "CartLines",
                newName: "IX_CartLines_OrderId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Orders",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartLines",
                table: "CartLines",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartLines_Orders_OrderId",
                table: "CartLines",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CartLines_Products_ProductId",
                table: "CartLines",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartLines_Orders_OrderId",
                table: "CartLines");

            migrationBuilder.DropForeignKey(
                name: "FK_CartLines_Products_ProductId",
                table: "CartLines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartLines",
                table: "CartLines");

            migrationBuilder.RenameTable(
                name: "CartLines",
                newName: "CartLine");

            migrationBuilder.RenameIndex(
                name: "IX_CartLines_ProductId",
                table: "CartLine",
                newName: "IX_CartLine_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_CartLines_OrderId",
                table: "CartLine",
                newName: "IX_CartLine_OrderId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Products",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Orders",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartLine",
                table: "CartLine",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartLine_Orders_OrderId",
                table: "CartLine",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CartLine_Products_ProductId",
                table: "CartLine",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
