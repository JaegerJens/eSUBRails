using esubmanager.common;
using esubmanager.model;
using esubmanager.hydrate;

namespace esubmanager.dispatcher
{
    public class EctdManagerGetChildrenRequest : IDispatchedStorageRequest
    {
        public EctdManagerGetChildrenRequest(HydratedTree request)
        {
            ParentElement = request.ParentElement;
        }

        public TreePath ParentElement { get; set; }
    }
}