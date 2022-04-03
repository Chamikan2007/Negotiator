using Negotiator.Contracts;

namespace Negotiator.TestWebAPI.Contracts
{
    public interface IWeatherForecastService
    {
        public IEnumerable<WeatherForecast> GetForecasts();
    }

    public interface IWeatherForecastService_GetForecasts_GetSummaryStates_Request : INegotiatorRequestHandler<string[]>
    {
    }
}
