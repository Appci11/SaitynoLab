using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaitynoLab.Server.Migrations
{
    public partial class Add_Parts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 10, 2, 15, 21, 3, 314, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 10, 2, 15, 21, 3, 314, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "Id", "Color", "FurnitureId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 5, 1, "Stalo koja V1", 9.9900000000000002 },
                    { 2, 5, 1, "Stalo koja V1", 9.9900000000000002 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 10, 2, 15, 21, 3, 314, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 10, 2, 15, 21, 3, 314, DateTimeKind.Local).AddTicks(3374));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2);

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
    }
}
