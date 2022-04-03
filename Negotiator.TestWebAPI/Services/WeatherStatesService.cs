using Negotiator.TestWebAPI.Contracts;

namespace Negotiator.TestWebAPI.Services
{
    public class WeatherStatesService : IWeatherStatesService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public string[] GetSummaryStates()
        {
            return Summaries;
        }
    }
}
