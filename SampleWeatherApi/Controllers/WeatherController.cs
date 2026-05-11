using Microsoft.AspNetCore.Mvc;
using SampleWeatherApi.Services;

namespace SampleWeatherApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(
            IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet("{city}")]
        public IActionResult GetWeather(string city)
        {
            var result = _weatherService.GetWeather(city);

            return Ok(result);
        }
    }
}