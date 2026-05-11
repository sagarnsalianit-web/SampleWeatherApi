using SampleWeatherApi.Models;

namespace SampleWeatherApi.Services
{
    public class WeatherService : IWeatherService
    {
        public Weather GetWeather(string city)
        {
            return new Weather
            {
                City = city,
                Temperature = "30°C"
            };
        }
    }
}