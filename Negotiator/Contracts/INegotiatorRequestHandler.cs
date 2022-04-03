namespace Negotiator.Contracts
{
    public interface INegotiatorRequestHandler<TResponse, TRequestParams>
    {
        public TResponse ExecuteRequest(TRequestParams requstParams);
    }

    public interface INegotiatorRequestHandler<TResponse>
    {
        public TResponse ExecuteRequest();
    }

    public interface IAsyncNegotiatorRequestHandler<TResponse, TRequestParams>
    {
        public Task<TResponse> ExecuteRequestAsync(TRequestParams requstParams);
    }

    public interface IAsyncNegotiatorRequestHandler<TResponse>
    {
        public Task<TResponse> ExecuteRequestAsync();
    }
}
