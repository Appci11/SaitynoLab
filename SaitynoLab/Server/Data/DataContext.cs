using Microsoft.EntityFrameworkCore;
using SaitynoLab.Shared;

namespace SaitynoLab.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
