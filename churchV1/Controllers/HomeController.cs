﻿using churchV1.Interface;
using churchV1.Models;
using churchV1.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace churchV1.Controllers
{
    [ApiController]
    
    public class HomeController : Controller
    {
        private readonly IHome service;

        public HomeController(IHome service)
        {
            this.service = service;
        }
        [Route("[controller]/getNavItems")]
        [HttpGet]
       public async Task<IActionResult> GetAllNavbarItems()
        {
            var items = await service.GetAllNevbar();        
                return Ok(items.Select(x => new{Name=x.Name.Trim(),Access=x.Access,Link=x.RoutLink.Trim()}));
                
        }
        [Route("[controller]/getContent")]
        [HttpGet]
        public async Task<IActionResult> GetContent()
        {
            var contents=await service.GetContents();
            return Ok(contents);
        }
    }
}
