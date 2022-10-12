using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaitynoLab.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Furniture",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToAssemble = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Furniture", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuyerId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FurnitureId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Color = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

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
                    { 1, 1, new DateTime(2022, 10, 12, 20, 35, 38, 251, DateTimeKind.Local).AddTicks(3543), "cclaire0@cloudflare.com", false, "+55 575 366 5029" },
                    { 2, 1, new DateTime(2022, 10, 12, 20, 35, 38, 251, DateTimeKind.Local).AddTicks(3575), "odagleas1@desdev.cn", false, "+55 126 791 9151" },
                    { 3, 1, new DateTime(2022, 10, 12, 20, 35, 38, 251, DateTimeKind.Local).AddTicks(3577), "chanson2@adobe.com", false, "+351 451 804 0946" },
                    { 4, 2, new DateTime(2022, 10, 12, 20, 35, 38, 251, DateTimeKind.Local).AddTicks(3579), "cbastiman3@bbb.org", false, "+46 907 344 5728" },
                    { 5, 2, new DateTime(2022, 10, 12, 20, 35, 38, 251, DateTimeKind.Local).AddTicks(3582), "lsafont4@ezinearticles.com", false, "+7 509 606 2496" }
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Furniture");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Parts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
