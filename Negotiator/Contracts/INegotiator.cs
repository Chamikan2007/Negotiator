namespace Negotiator.Contracts
{
    public interface INegotiator
    {
        public TResponse Request<TRequestHandler, TResponse, TRequestParams>(TRequestParams requestParams)
            where TRequestHandler : INegotiatorRequestHandler<TResponse, TRequestParams>;

        public TResponse Request<TRequestHandler, TResponse>()
            where TRequestHandler : INegotiatorRequestHandler<TResponse>;

        public Task<TResponse> RequestAsync<TRequestHandler, TResponse, TRequestParams>(TRequestParams requestParams)
            where TRequestHandler : IAsyncNegotiatorRequestHandler<TResponse, TRequestParams>;

        public Task<TResponse> RequestAsync<TRequestHandler, TResponse>()
            where TRequestHandler : IAsyncNegotiatorRequestHandler<TResponse>;
    }
}
