using Microsoft.AspNetCore.Mvc;
using Zoo.DTO;
using Zoo.Models;

namespace Zoo.Controllers
{
    [ApiController]
    [Route("zoo-api/")]
    public class ZoneController : Controller
    {
        public ZoneController() { }

        [HttpGet("get-zones")]
        public async Task<IActionResult> GetZones()
        {
            ZoneDTO zone = new ZoneDTO("1","Marina",5000);
            return Ok(zone);
        }

        [HttpPost("add-zones")]
        public async Task<IActionResult> AddZones(ZoneDTO zone)
        {
            MZone mZone = new MZone();
            return Ok(mZone.AddZone(zone));
        }
    }
}