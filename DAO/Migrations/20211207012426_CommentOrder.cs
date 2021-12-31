using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class CommentOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.AddColumn<string>(
                name: "PostalOffice",
                table: "Addresses",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_Addresses_AddressId",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PostalOffice",
                table: "Addresses");

            migrationBuilder.AlterColumn<long>(
                name: "AddressId",
                table: "AppUsers",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_Addresses_AddressId",
                table: "AppUsers",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
