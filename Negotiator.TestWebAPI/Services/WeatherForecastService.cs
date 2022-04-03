using Negotiator.TestWebAPI.Contracts;

namespace Negotiator.TestWebAPI.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        public readonly IWeatherStatesService _weatherStatesService;

        public WeatherForecastService(IWeatherStatesService weatherStatesService)
        {
            _weatherStatesService = weatherStatesService;
        }

        public IEnumerable<WeatherForecast> GetForecasts()
        {
            var summaries = _weatherStatesService.GetSummaryStates();

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = summaries[Random.Shared.Next(summaries.Length)]
            })
            .ToArray();
        }
    }
}
