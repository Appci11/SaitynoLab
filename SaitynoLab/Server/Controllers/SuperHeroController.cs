using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaitynoLab.Server.Data;
using SaitynoLab.Shared;

namespace SaitynoLab.Server.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class SuperHeroController : ControllerBase
    {
        List<SuperHero> heroes = new List<SuperHero>
        {
            new SuperHero { Id = 1, FirstName = "Peter", LastName = "Parker", HeroName = "Spooderman" },
            new SuperHero { Id = 2, FirstName = "Bruce", LastName = "Wayne", HeroName = "Batman" }
        };
        private readonly DataContext _context;

        public SuperHeroController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetSuperHeroes()
        {
            return base.Ok(await GetDbHeroes());
        }

        private async Task<List<SuperHero>> GetDbHeroes()
        {
            return await _context.SuperHeroes.ToListAsync();
        }

        //[HttpGet("{id}")]
        public async Task<IActionResult> GetSingleSuperHero(int id)
        {
            var hero = await _context.SuperHeroes.FirstOrDefaultAsync(h => h.Id == id);
            if (hero == null)
            {
                return NotFound("Super Hero was not found.");
            }
            return Ok(hero);
        }
        [HttpPost]
        public async Task<IActionResult> CreateSuperHero(SuperHero hero)
        {
            _context.SuperHeroes.Add(hero);
            await _context.SaveChangesAsync();
            return Ok(await GetDbHeroes());
        }
        //[HttpPut("{id}")]
        public async Task<IActionResult> UpdateSuperHero(SuperHero hero, int id)
        {
            var dbHero = await _context.SuperHeroes.FirstOrDefaultAsync(h => h.Id == id);
            if (dbHero == null)
            {
                return NotFound("Super Hero was not found.");
            }

            dbHero.FirstName = hero.FirstName;
            dbHero.LastName = hero.LastName;
            dbHero.HeroName = hero.HeroName;

            await _context.SaveChangesAsync();

            return Ok(await GetDbHeroes());
        }
        //[HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSuperHero(int id)
        {
            var dbHero = await _context.SuperHeroes.FirstOrDefaultAsync(h => h.Id == id);
            if (dbHero == null)
            {
                return NotFound("Super Hero was not found.");
            }

            _context.SuperHeroes.Remove(dbHero);
            await _context.SaveChangesAsync();

            return Ok(await GetDbHeroes());
        }
    }
}
