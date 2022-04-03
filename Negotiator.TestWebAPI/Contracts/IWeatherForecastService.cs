using Negotiator.Contracts;

namespace Negotiator.TestWebAPI.Contracts
{
    public interface IWeatherForecastService
    {
        public Task<IEnumerable<WeatherForecast>> GetForecasts();
    }

    public interface IWeatherForecastService_GetForecasts_GetSummaryStates_Request : IAsyncNegotiatorRequestHandler<string[]>
    {
    }
}
