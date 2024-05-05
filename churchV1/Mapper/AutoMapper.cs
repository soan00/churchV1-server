﻿using AutoMapper;
using churchV1.Models;
using DataBase.DTO;

namespace churchV1.Mapper
{
    public class AutoMapper:Profile
    {
        public AutoMapper()
        {
            CreateMap<NavbarDTO,NavbarModel>();
            CreateMap<NavbarModel,NavbarDTO>();
        }
    }
}