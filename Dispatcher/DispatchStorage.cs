using System;
using System.Linq;
using esubmanager.common;
using esubmanager.model;
using esubmanager.hydrate;

namespace esubmanager.dispatcher
{
    public class DispatchStorage : IGetChildrenRequestService<HydratedTree, IDispatchedStorageRequest>
    {
        public IDispatchedStorageRequest Handle(HydratedTree request)
        {
            if (request.ParentElement.Any(e => e is CifsStorage))
            {
                return new CifsGetChildrenRequest
                {
                    ParentElement = request.ParentElement
                };
            }
            if (request.ParentElement.Any(e => e is EctdStorage))
            {
                return new EctdManagerGetChildrenRequest
                {
                    ParentElement = request.ParentElement
                };
            }
            throw new NotImplementedException();
        }
    }
}