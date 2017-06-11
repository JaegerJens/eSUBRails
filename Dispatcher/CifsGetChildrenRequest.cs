using esubmanager.common;
using esubmanager.model;

namespace esubmanager.dispatcher
{
    public class CifsGetChildrenRequest : IDispatchedStorageRequest
    {
        public TreePath ParentElement { get; set; }
    }
}