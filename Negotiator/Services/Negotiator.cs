using Microsoft.Extensions.DependencyInjection;
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

        public TResponse Request<TRequestHandler, TResponse, TRequestParams>(TRequestParams requestParams)
            where TRequestHandler : INegotiatorRequestHandler<TResponse, TRequestParams>
        {
            var requetsHandler = _serviceProvider.GetService<TRequestHandler>();

            if (requetsHandler != null)
                return requetsHandler.ExecuteRequest(requestParams);

            return default;
        }

        public TResponse Request<TRequestHandler, TResponse>()
            where TRequestHandler : INegotiatorRequestHandler<TResponse>
        {
            var requetsHandler = _serviceProvider.GetService<TRequestHandler>();

            if (requetsHandler != null)
                return requetsHandler.ExecuteRequest();

            return default;
        }

        public Task<TResponse> RequestAsync<TRequestHandler, TResponse, TRequestParams>(TRequestParams requestParams)
            where TRequestHandler : IAsyncNegotiatorRequestHandler<TResponse, TRequestParams>
        {
            var requetsHandler = _serviceProvider.GetService<TRequestHandler>();

            if (requetsHandler != null)
                return requetsHandler.ExecuteRequestAsync(requestParams);

            return default;
        }

        public Task<TResponse> RequestAsync<TRequestHandler, TResponse>()
            where TRequestHandler : IAsyncNegotiatorRequestHandler<TResponse>
        {
            var requetsHandler = _serviceProvider.GetService<TRequestHandler>();

            if (requetsHandler != null)
                return requetsHandler.ExecuteRequestAsync();

            return default;
        }
    }
}