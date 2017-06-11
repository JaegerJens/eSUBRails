using esubmanager.model;

namespace esubmanager.common
{
    public interface IGetChildrenRequest
    {
        TreePath ParentElement { get; set; }
    }
}
