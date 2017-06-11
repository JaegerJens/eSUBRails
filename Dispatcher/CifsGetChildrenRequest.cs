using esubmanager.common;
using esubmanager.model;
using esubmanager.hydrate;

namespace esubmanager.dispatcher
{
    public class CifsGetChildrenRequest : IDispatchedStorageRequest
    {
        public CifsGetChildrenRequest(HydratedTree request)
        {
            ParentElement = request.ParentElement;
        }

        public TreePath ParentElement { get; set; }
    }
}