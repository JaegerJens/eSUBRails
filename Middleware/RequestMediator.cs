using System;

namespace esubmanager.middleware
{
    public class RequestMediator
    {
        private readonly Container _container;

        public RequestMediator(Container container)
        {
            _container = container;
        }

        public TOutput Handle<TInput, TOutput>(TInput input)
        {
            throw new NotImplementedException();
        }
    }
}