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
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}