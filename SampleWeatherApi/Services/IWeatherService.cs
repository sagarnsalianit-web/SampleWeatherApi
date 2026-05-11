using SampleWeatherApi.Models;

namespace SampleWeatherApi.Services
{
    public interface IWeatherService
    {
        Weather GetWeather(string city);
    }
}

