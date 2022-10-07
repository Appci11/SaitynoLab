//Kadangi skleroze kankina tai...
//in server dir
//dotnet ef migrations add <insert whatever here>
//dotnet ef database update
//dotnet ef migrations remove       removes last migration

using Microsoft.EntityFrameworkCore;
using SaitynoLab.Shared;

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
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "User1" },
                new User { Id = 2, Username = "User2" }
            );
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
                },
                new Order
                {
                    Id = 3,
                    BuyerId = 1,
                    Email = "chanson2@adobe.com",
                    PhoneNumber = "+351 451 804 0946"
                },
                new Order
                {
                    Id = 4,
                    BuyerId = 2,
                    Email = "cbastiman3@bbb.org",
                    PhoneNumber = "+46 907 344 5728"
                },
                new Order
                {
                    Id = 5,
                    BuyerId = 2,
                    Email = "lsafont4@ezinearticles.com",
                    PhoneNumber = "+7 509 606 2496"
                }
            );
            modelBuilder.Entity<Furniture>().HasData(
                new Furniture
                {
                    Id = 1,
                    OrderId = 1,
                    Name = "Kėdė v1"
                },
                new Furniture
                {
                    Id = 2,
                    OrderId = 1,
                    Name = "Kėdė v2"
                },
                new Furniture
                {
                    Id = 3,
                    OrderId = 1,
                    Name = "Stalas v1"
                },
                new Furniture
                {
                    Id = 4,
                    OrderId = 2,
                    Name = "Stalas v2"
                },
                new Furniture
                {
                    Id = 5,
                    OrderId = 2,
                    Name = "Knygų lentyna v1"
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
                    Name = "Stalo viršus V1",
                    Price = 18.99
                }
            );
        }
    }
}


