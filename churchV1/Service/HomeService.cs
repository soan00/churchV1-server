﻿using AutoMapper;
using churchV1.Interface;
using churchV1.Models;
using DataBase.AccessLayer;
using DataBase.DTO;
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

        public async Task<Dictionary<string,object>> GetContents(int pageNumber,int pageSize)
        {
            var data = await homeRepo.getContents(pageNumber,pageSize);
            return data;
        }

        public async Task<IEnumerable<EventModel>> GetEvents()
        {
            var events= await homeRepo.getEvents();
            var map=mapper.Map<IEnumerable<EventModel>>(events);
            return map.Where(x => x.Active == true);
        }

        public async Task<bool> postPrayerRequest(PrayerModel prayer)
        {
            var map=mapper.Map<PrayerDTO>(prayer);
            var result = await homeRepo.postPrayerRequest(map);
            return result;
        }
    }
}
