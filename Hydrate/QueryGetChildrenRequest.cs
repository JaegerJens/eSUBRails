using esubmanager.common;

namespace esubmanager.hydrate
{
    public class QueryGetChildrenRequest : IGetChildrenRequest
    {
        public TreePath ParentElement {get; set;}
    }
}
