using churchV1.Interface;
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
            if (items != null && items.Any())
                return Ok(items.Select(x => new { Name = x.Name.Trim(), Access = x.Access, Link = x.RoutLink.Trim() }));
            else
                return BadRequest("No data found");

        }
        [Route("[controller]/getContent")]
        [HttpGet]
        public async Task<IActionResult> GetContent(int pageNumber,int pageSize)
        {
            var contents = await service.GetContents(pageNumber,pageSize);
            return Ok(contents);
        }
        [Route("[controller]/getEvent")]
        [HttpGet]
        public async Task<IActionResult> GetEvent()
        {
            try
            {
                var events = await service.GetEvents();
                return Ok(events);
            }
            catch (Exception ex) { return BadRequest(ex.Message); }

        }
        [Route("[controller]/postPrayer")]
        [HttpPost]
        public async Task<IActionResult> PostPrayer([FromBody] PrayerModel model)
        {
            try
            {
                var result=await service.postPrayerRequest(model);
                if (result == true)
                    return Ok(new { message="Your Prayer Request Submitted" });
                else
                    return BadRequest("Something went wrong, Please try again");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
