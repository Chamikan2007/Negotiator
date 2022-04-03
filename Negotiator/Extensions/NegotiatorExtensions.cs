using Microsoft.Extensions.DependencyInjection;
using Negotiator.Contracts;

namespace Negotiator.Extensions
{
    public static class NegotiatorExtensions
    {
        public static IServiceCollection AddNegotiator(this IServiceCollection serviceCollection)
        {
            return serviceCollection.AddScoped<INegotiator>(s => new Services.Negotiator(s));
        }
    }
}
