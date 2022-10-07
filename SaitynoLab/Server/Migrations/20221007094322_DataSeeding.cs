using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaitynoLab.Server.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Furniture",
                columns: new[] { "Id", "Name", "OrderId", "ToAssemble" },
                values: new object[,]
                {
                    { 1, "Kėdė v1", 1, true },
                    { 2, "Kėdė v2", 1, true },
                    { 3, "Stalas v1", 1, true },
                    { 4, "Stalas v2", 2, true },
                    { 5, "Knygų lentyna v1", 2, true }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "BuyerId", "DateCreated", "Email", "IsCompleted", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 10, 7, 12, 43, 21, 864, DateTimeKind.Local).AddTicks(2934), "cclaire0@cloudflare.com", false, "+55 575 366 5029" },
                    { 2, 1, new DateTime(2022, 10, 7, 12, 43, 21, 864, DateTimeKind.Local).AddTicks(2937), "odagleas1@desdev.cn", false, "+55 126 791 9151" },
                    { 3, 1, new DateTime(2022, 10, 7, 12, 43, 21, 864, DateTimeKind.Local).AddTicks(2940), "chanson2@adobe.com", false, "+351 451 804 0946" },
                    { 4, 2, new DateTime(2022, 10, 7, 12, 43, 21, 864, DateTimeKind.Local).AddTicks(2942), "cbastiman3@bbb.org", false, "+46 907 344 5728" },
                    { 5, 2, new DateTime(2022, 10, 7, 12, 43, 21, 864, DateTimeKind.Local).AddTicks(2944), "lsafont4@ezinearticles.com", false, "+7 509 606 2496" }
                });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "Id", "Color", "FurnitureId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 5, 1, "Kėdės kojos V1", 9.9900000000000002 },
                    { 2, 5, 2, "Kėdės kojos V2", 9.9900000000000002 },
                    { 3, 5, 1, "Stalo kojos V1", 20.989999999999998 },
                    { 4, 5, 2, "Stalo kojos V2", 20.989999999999998 },
                    { 5, 5, 1, "Kėdės viršus V1", 8.9900000000000002 },
                    { 6, 5, 2, "Kėdės viršus V2", 8.9900000000000002 },
                    { 7, 5, 1, "Stalo viršus V1", 17.989999999999998 },
                    { 8, 5, 2, "Stalo viršus V1", 18.989999999999998 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateCreated", "PasswordHash", "PasswordSalt", "Username", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 7, 12, 43, 21, 864, DateTimeKind.Local).AddTicks(2829), null, null, "User1", false },
                    { 2, new DateTime(2022, 10, 7, 12, 43, 21, 864, DateTimeKind.Local).AddTicks(2860), null, null, "User2", false }
                });
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

            migrationBuilder.DeleteData(
                table: "Furniture",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Furniture",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Furniture",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8);

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
