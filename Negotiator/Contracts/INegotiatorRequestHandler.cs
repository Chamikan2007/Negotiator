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
}
