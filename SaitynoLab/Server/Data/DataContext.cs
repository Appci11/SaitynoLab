//Kadangi skleroze kankina tai...
//in server dir
//dotnet ef migrations add <insert whatever here>
//dotnet ef database update

using Microsoft.EntityFrameworkCore;
using SaitynoLab.Shared;

namespace SaitynoLab.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SuperHero>().HasData(
                new SuperHero { Id = 1, FirstName = "Peter", LastName = "Parker", HeroName = "Spooderman" },
                new SuperHero { Id = 2, FirstName = "Bruce", LastName = "Wayne", HeroName = "Batman" }
            );
            //modelBuilder.Entity<User>().HasData(
            //    new User { Id = 1, Username = "User1" },
            //    new User { Id = 2, Username = "User2" }
            //);
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}