using AutoMapper;
using churchV1.Interface;
using churchV1.Models;
using DataBase.AccessLayer;

namespace churchV1.Service
{
    public class NavbarService : INavbar
    {
        private readonly NavbarRepo repo;
        private readonly IMapper mapper;

        public NavbarService(NavbarRepo repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<NavbarModel>> GetAllNevbar()
        {
            var data = await repo.GetNavbarItem();
            var map = mapper.Map<IEnumerable<NavbarModel>>(data);
            return map.Where(x=>x.Active!=false);

        }
    }
}
