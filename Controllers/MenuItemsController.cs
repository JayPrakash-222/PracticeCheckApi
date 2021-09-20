using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCheckApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemsController : ControllerBase
    {
        List<MenuItem> items = new List<MenuItem>()
            {
                new MenuItem() { Id=1,Name="Chicken 65",FreeDelivery=true,Price=150.00,DateOfLaunch=DateTime.Now,Active=true},
                new MenuItem() { Id=2,Name="Chicken lollypop",FreeDelivery=true,Price=160.00,DateOfLaunch=DateTime.Now,Active=true},
                new MenuItem() { Id=3,Name="Chicken Tikka",FreeDelivery=true,Price=250.00,DateOfLaunch=DateTime.Now,Active=false},
                new MenuItem() { Id=4,Name="Biryani",FreeDelivery=true,Price=250.00,DateOfLaunch=DateTime.Now,Active=true},
            };
        [HttpGet]
        public IActionResult GetItem()
        {
            return Ok(items);
        }
        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            MenuItem item = items.Find(s=> s.Id==id);
            if (item == null)
                return NotFound("Not found!!!");
            else
            {
                return Ok(item);
            }
        }
    }
}
