using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaitynoLab.Server.Migrations
{
    public partial class Add_Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateCreated", "PasswordHash", "PasswordSalt", "Username", "isDeleted" },
                values: new object[] { 1, new DateTime(2022, 10, 2, 15, 18, 14, 831, DateTimeKind.Local).AddTicks(6807), null, null, "User1", false });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateCreated", "PasswordHash", "PasswordSalt", "Username", "isDeleted" },
                values: new object[] { 2, new DateTime(2022, 10, 2, 15, 18, 14, 831, DateTimeKind.Local).AddTicks(6836), null, null, "User2", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
