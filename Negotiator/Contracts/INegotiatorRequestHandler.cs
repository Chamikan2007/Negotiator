namespace Negotiator.Contracts
{
    public interface INegotiatorRequestHandler<TResponse, TRequestParams>
    {
        public TResponse ExecuteRequest(TRequestParams requstParams);
    }
}
