using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaitynoLab.Server.Migrations
{
    public partial class Add_Furniture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Furniture",
                columns: new[] { "Id", "Name", "OrderId", "ToAssemble" },
                values: new object[,]
                {
                    { 1, "Stalas1", 1, true },
                    { 2, "Stalas2", 1, true }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 10, 2, 15, 20, 10, 960, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 10, 2, 15, 20, 10, 960, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 10, 2, 15, 20, 10, 960, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 10, 2, 15, 20, 10, 960, DateTimeKind.Local).AddTicks(7075));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Furniture",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Furniture",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 10, 2, 15, 19, 19, 446, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 10, 2, 15, 19, 19, 446, DateTimeKind.Local).AddTicks(1505));

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
    }
}
