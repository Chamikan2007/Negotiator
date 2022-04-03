using Negotiator.Contracts;

namespace Negotiator.Services
{
    public class Negotiator : INegotiator
    {
        private readonly IServiceProvider _serviceProvider;

        public Negotiator(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
    }
}