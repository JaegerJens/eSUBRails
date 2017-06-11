namespace esubmanager.common
{
    public interface IGetChildrenRequestService<TInput, TOutput>
        where TInput : IGetChildrenRequest
        where TOutput : IGetChildrenRequest
    {
        TOutput Handle(TInput input);
    }
}