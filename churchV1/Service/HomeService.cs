using AutoMapper;
using churchV1.Interface;
using churchV1.Models;
using DataBase.AccessLayer;
using Microsoft.VisualBasic;

namespace churchV1.Service
{
    public class HomeService : IHome
    {        
        private readonly NavbarRepo nevRepo;
        private readonly IMapper mapper;
        private readonly HomeRepo homeRepo;

        public HomeService(NavbarRepo nevRepo, IMapper mapper,HomeRepo homeRepo)
        {          
            this.nevRepo = nevRepo;
            this.mapper = mapper;
            this.homeRepo = homeRepo;
        }
        public async Task<IEnumerable<NavbarModel>> GetAllNevbar()
        {
            var data = await nevRepo.GetNavbarItem();
            var map = mapper.Map<IEnumerable<NavbarModel>>(data);
            return map.Where(x=>x.Active!=false);

        }

        public async Task<IEnumerable<ContentModel>> GetContents()
        {
            var data = await homeRepo.getContents();
            var map= mapper.Map<IEnumerable<ContentModel>>(data);
            return map.Where(x=>x.Active==true);
        }
    }
}
