//Kadangi skleroze kankina tai...
//in server dir
//dotnet ef migrations add <insert whatever here>
//dotnet ef database update
//dotnet ef migrations remove       removes last migration

using Microsoft.EntityFrameworkCore;
using SaitynoLab.Shared;
using static System.Net.WebRequestMethods;

namespace SaitynoLab.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Furniture> Furniture { get; set; }
        public DbSet<Part> Parts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //nebetinka, nes kode naudojam passHash etc...
            //modelBuilder.Entity<User>().HasData(
            //    new User { Id = 1, Username = "User1" },
            //    new User { Id = 2, Username = "User2" }
            //);
            modelBuilder.Entity<SaitynoLab.Shared.Order>().HasData(
                new Order
                {
                    Id = 1,
                    BuyerId = 1,
                    Email = "cclaire0@cloudflare.com",
                    PhoneNumber = "+55 575 366 5029"
                },
                new Order
                {
                    Id = 2,
                    BuyerId = 1,
                    Email = "odagleas1@desdev.cn",
                    PhoneNumber = "+55 126 791 9151"
                }
            );
            modelBuilder.Entity<Furniture>().HasData(
                new Furniture
                {
                    Id = 1,
                    OrderId = 1,
                    Name = "Kėdė v1",
                    ImageUrl = "https://www.publicdomainpictures.net/pictures/80000/velka/chair-clipart.jpg"

                },
                new Furniture
                {
                    Id = 2,
                    OrderId = 1,
                    Name = "Kėdė v2",
                    ImageUrl = "https://www.pngmart.com/files/15/Wooden-Antique-Chair-PNG-Free-Download.png"
                },
                new Furniture
                {
                    Id = 3,
                    OrderId = 1,
                    Name = "Stalas v1",
                    ImageUrl = "https://www.thesprucecrafts.com/thmb/9ZYpOqR3YHO3vUd4eJqBaXr_TAU=/750x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/woodgears-dining-table-5696ad753df78cafda8f5854.png"
                },
                new Furniture
                {
                    Id = 4,
                    OrderId = 2,
                    Name = "Stalas v2",
                    ImageUrl = "https://p.turbosquid.com/ts-thumb/PP/2eYUS5/pY48APl0/logo/png/1580766180/1920x1080/fit_q99/cc21a59fb6ea56d96cb2519aa6261ba5d3b724a0/logo.jpg"
                }
            );
            modelBuilder.Entity<Part>().HasData(
                new Part
                {
                    Id = 1,
                    FurnitureId = 1,
                    Name = "Kėdės kojos V1",
                    Price = 9.99
                },
                new Part
                {
                    Id = 2,
                    FurnitureId = 2,
                    Name = "Kėdės kojos V2",
                    Price = 9.99
                },
                new Part
                {
                    Id = 3,
                    FurnitureId = 1,
                    Name = "Stalo kojos V1",
                    Price = 20.99
                },
                new Part
                {
                    Id = 4,
                    FurnitureId = 2,
                    Name = "Stalo kojos V2",
                    Price = 20.99
                },
                new Part
                {
                    Id = 5,
                    FurnitureId = 1,
                    Name = "Kėdės viršus V1",
                    Price = 8.99
                },
                new Part
                {
                    Id = 6,
                    FurnitureId = 2,
                    Name = "Kėdės viršus V2",
                    Price = 8.99
                },
                new Part
                {
                    Id = 7,
                    FurnitureId = 1,
                    Name = "Stalo viršus V1",
                    Price = 17.99
                },
                new Part
                {
                    Id = 8,
                    FurnitureId = 2,
                    Name = "Stalo viršus V2",
                    Price = 18.99
                }
            );
        }
    }
}


