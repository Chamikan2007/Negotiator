namespace Negotiator.Contracts
{
    public interface INegotiator
    {
        public TResponse Request<TRequestHandler, TResponse, TRequestParams>(TRequestParams requestParams)
            where TRequestHandler : INegotiatorRequestHandler<TResponse, TRequestParams>;

        public TResponse Request<TRequestHandler, TResponse>()
            where TRequestHandler : INegotiatorRequestHandler<TResponse>;
    }
}
