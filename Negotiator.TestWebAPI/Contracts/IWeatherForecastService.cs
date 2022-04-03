namespace Negotiator.TestWebAPI.Contracts
{
    public interface IWeatherForecastService
    {
        public IEnumerable<WeatherForecast> GetForecasts();
    }
}
