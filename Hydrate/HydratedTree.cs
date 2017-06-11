using esubmanager.common;
using esubmanager.model;

namespace esubmanager.hydrate
{
    public class HydratedTree : IGetChildrenRequest
    {
        public TreePath ParentElement {get; set;}
    }
}
