using esubmanager.common;
using esubmanager.model;

namespace esubmanager.hydrate
{
    public class QueryGetChildrenRequest : IGetChildrenRequest
    {
        public TreePath ParentElement {get; set;}
    }
}
