using churchV1.Interface;
using churchV1.Models;
using churchV1.Service;
using Microsoft.AspNetCore.Mvc;

namespace churchV1.Controllers
{
    [ApiController]
    
    public class HomeController : Controller
    {
        private readonly INavbar service;

        public HomeController(INavbar service)
        {
            this.service = service;
        }
        [Route("[controller]/getNavItems")]
        [HttpGet]
       public async Task<IActionResult> GetAllNavbarItems()
        {
            var items = await service.GetAllNevbar();        
                return Ok(items);
                
        }
    }
}
