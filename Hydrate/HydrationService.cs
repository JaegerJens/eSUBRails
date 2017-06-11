using System;
using System.Collections;
using esubmanager.common;

namespace esubmanager.hydrate
{
    public class HydrationService : IGetChildrenRequestService<QueryGetChildrenRequest, HydratedTree>
    {
        public HydratedTree Handle(QueryGetChildrenRequest request)
        {
            return new HydratedTree
            {
                ParentElement = request.ParentElement
            };
        }
    }
}
