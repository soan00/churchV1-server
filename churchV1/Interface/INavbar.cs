using churchV1.Models;

namespace churchV1.Interface
{
    public interface INavbar
    {
        Task<IEnumerable<NavbarModel>> GetAllNevbar();
    }
}
