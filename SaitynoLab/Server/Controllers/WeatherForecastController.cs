using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SaitynoLab.Shared;

namespace SaitynoLab.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    // Arba Authorize cia visam controller, ir AllowAnonymous atskiriem endpoint
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //[HttpGet]
        //automatiskai suteikia identiska, bet taip aiskiau
        [HttpGet(Name = "GetWeatherForecast"), Authorize(Roles = "Admin")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}