using esubmanager.common;
using esubmanager.model;

namespace esubmanager.dispatcher
{
    public class EctdManagerGetChildrenRequest : IDispatchedStorageRequest
    {
        public TreePath ParentElement { get; set; }
    }
}