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
                    Email = "Pvz.pastas@kazkas.com",
                    PhoneNumber = "867864264"
                },
                new Order
                {
                    Id = 2,
                    BuyerId = 1,
                    Email = "Pvz.pastas@kazkas.com",
                    PhoneNumber = "867864264"
                }
            );
            modelBuilder.Entity<Furniture>().HasData(
                new Furniture
                {
                    Id = 1,
                    OrderId = 1,
                    Name = "Stalas1"
                },
                new Furniture
                {
                    Id = 2,
                    OrderId = 1,
                    Name = "Stalas2"
                }
            );
            modelBuilder.Entity<Part>().HasData(
                new Part
                {
                    Id = 1,
                    FurnitureId = 1,
                    Name = "Stalo koja V1",
                    Price = 9.99
                },
                new Part
                {
                    Id = 2,
                    FurnitureId = 1,
                    Name = "Stalo koja V1",
                    Price = 9.99
                }
            );
        }
    }
}


