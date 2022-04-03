using Negotiator.Contracts;
using Negotiator.TestWebAPI.Contracts;

namespace Negotiator.TestWebAPI.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        public readonly IWeatherStatesService _weatherStatesService;
        public readonly INegotiator _negotiator;

        public WeatherForecastService(IWeatherStatesService weatherStatesService, INegotiator negotiator)
        {
            _weatherStatesService = weatherStatesService;
            _negotiator = negotiator;
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
