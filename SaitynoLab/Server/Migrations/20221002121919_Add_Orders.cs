using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaitynoLab.Server.Migrations
{
    public partial class Add_Orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "BuyerId", "DateCreated", "Email", "IsCompleted", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 10, 2, 15, 19, 19, 446, DateTimeKind.Local).AddTicks(1502), "Pvz.pastas@kazkas.com", false, "867864264" },
                    { 2, 1, new DateTime(2022, 10, 2, 15, 19, 19, 446, DateTimeKind.Local).AddTicks(1505), "Pvz.pastas@kazkas.com", false, "867864264" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 10, 2, 15, 19, 19, 446, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 10, 2, 15, 19, 19, 446, DateTimeKind.Local).AddTicks(1415));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 10, 2, 15, 18, 14, 831, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 10, 2, 15, 18, 14, 831, DateTimeKind.Local).AddTicks(6836));
        }
    }
}
