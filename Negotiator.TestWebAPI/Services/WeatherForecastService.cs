using Negotiator.Contracts;
using Negotiator.TestWebAPI.Contracts;

namespace Negotiator.TestWebAPI.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        public readonly INegotiator _negotiator;

        public WeatherForecastService(INegotiator negotiator)
        {
            _negotiator = negotiator;
        }

        public async Task<IEnumerable<WeatherForecast>> GetForecasts()
        {
            var summaries = await _negotiator.RequestAsync<IWeatherForecastService_GetForecasts_GetSummaryStates_Request, string[]>();

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = summaries[Random.Shared.Next(summaries.Length)]
            })
            .ToArray();
        }
    }

    public class WeatherForecastService_GetForecasts_GetSummaryStates_Request : IWeatherForecastService_GetForecasts_GetSummaryStates_Request
    {
        private readonly IWeatherStatesService _weatherStatesService;

        public WeatherForecastService_GetForecasts_GetSummaryStates_Request(IWeatherStatesService weatherStatesService)
        {
            _weatherStatesService = weatherStatesService;
        }

        public Task<string[]> ExecuteRequestAsync()
        {
            return Task.FromResult(_weatherStatesService.GetSummaryStates());
        }
    }
}
