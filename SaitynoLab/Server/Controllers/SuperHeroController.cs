using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaitynoLab.Shared;

namespace SaitynoLab.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        List<SuperHero> heroes = new List<SuperHero>
        {
            new SuperHero { Id = 1, FirstName = "Peter", LastName = "Parker", HeroName = "Spooderman" },
            new SuperHero { Id = 2, FirstName = "Bruce", LastName = "Wayne", HeroName = "Batman" }
        };

        [HttpGet]
        public async Task<IActionResult> GetSuperHeroes()
        {
            return Ok(heroes);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleSuperHero(int id)
        {
            var hero = heroes.FirstOrDefault(h => h.Id == id);
            if (hero == null)
            {
                return NotFound("Super Hero was not found.");
            }
            return Ok(hero);
        }
        [HttpPost]
        public async Task<IActionResult> CreateSuperHero(SuperHero hero)
        {
            heroes.Add(hero);
            return Ok(heroes);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSuperHero(SuperHero hero, int id)
        {
            var dbHero = heroes.FirstOrDefault(h => h.Id == id);
            if (dbHero == null)
            {
                return NotFound("Super Hero was not found.");
            }

            var index = heroes.IndexOf(dbHero);
            heroes[index] = hero;

            return Ok(heroes);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSuperHero(int id)
        {
            var dbHero = heroes.FirstOrDefault(h => h.Id == id);
            if (dbHero == null)
            {
                return NotFound("Super Hero was not found.");
            }

            heroes.Remove(dbHero);

            return Ok(heroes);
        }
    }
}
