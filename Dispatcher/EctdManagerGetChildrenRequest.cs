using esubmanager.common;

namespace esubmanager.dispatcher
{
    public class EctdManagerGetChildrenRequest : IDispatchedStorageRequest
    {
        public TreePath ParentElement { get; set; }
    }
}