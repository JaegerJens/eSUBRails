using esubmanager.common;

namespace esubmanager.hydrate
{
    public class HydratedTree : IGetChildrenRequest
    {
        public TreePath ParentElement {get; set;}
    }
}
