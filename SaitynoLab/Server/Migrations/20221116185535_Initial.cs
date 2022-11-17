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
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                columns: new[] { "Id", "ImageUrl", "Name", "OrderId", "ToAssemble" },
                values: new object[,]
                {
                    { 1, "https://www.publicdomainpictures.net/pictures/80000/velka/chair-clipart.jpg", "Kėdė v1", 1, true },
                    { 2, "https://www.pngmart.com/files/15/Wooden-Antique-Chair-PNG-Free-Download.png", "Kėdė v2", 1, true },
                    { 3, "https://www.thesprucecrafts.com/thmb/9ZYpOqR3YHO3vUd4eJqBaXr_TAU=/750x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/woodgears-dining-table-5696ad753df78cafda8f5854.png", "Stalas v1", 1, true },
                    { 4, "https://p.turbosquid.com/ts-thumb/PP/2eYUS5/pY48APl0/logo/png/1580766180/1920x1080/fit_q99/cc21a59fb6ea56d96cb2519aa6261ba5d3b724a0/logo.jpg", "Stalas v2", 2, true }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "BuyerId", "DateCreated", "Email", "IsCompleted", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 11, 16, 20, 55, 35, 205, DateTimeKind.Local).AddTicks(4273), "cclaire0@cloudflare.com", false, "+55 575 366 5029" },
                    { 2, 1, new DateTime(2022, 11, 16, 20, 55, 35, 205, DateTimeKind.Local).AddTicks(4307), "odagleas1@desdev.cn", false, "+55 126 791 9151" }
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
                    { 8, 5, 2, "Stalo viršus V2", 18.989999999999998 }
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
