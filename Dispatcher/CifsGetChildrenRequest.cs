using esubmanager.common;

namespace esubmanager.dispatcher
{
    public class CifsGetChildrenRequest : IDispatchedStorageRequest
    {
        public TreePath ParentElement { get; set; }
    }
}