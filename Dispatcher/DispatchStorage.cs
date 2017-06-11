using System;
using esubmanager.common;
using esubmanager.hydrate;

namespace esubmanager.dispatcher
{
    public class DispatchStorage : IGetChildrenRequestService<HydratedTree, IDispatchedStorageRequest>
    {
        public IDispatchedStorageRequest Handle(HydratedTree request)
        {
            throw new NotImplementedException();
        }
    }
}