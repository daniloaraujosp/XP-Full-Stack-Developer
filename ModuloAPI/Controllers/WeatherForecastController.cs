using Microsoft.AspNetCore.Mvc;

namespace ModuloAPI.Controllers
{

    [ApiController]

    [Route("api/[controller]")]

    public class WeatherForecastController : ControllerBase

    {

        private static readonly string[] Summaries = new[]

        {

            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"

        };



        [HttpGet("ObterClima")]

        public IEnumerable<WeatherForecast> Get()

        {

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast

            {

                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),

                TemperatureC = Random.Shared.Next(-20, 55),

                Summary = Summaries[Random.Shared.Next(Summaries.Length)]

            })

            .ToArray();

        }

    }



    public record WeatherForecast

    {

        public DateOnly Date { get; init; }

        public int TemperatureC { get; init; }

        public string? Summary { get; init; }



        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    }

}