using Microsoft.AspNetCore.Mvc;
using Zoo.DTO;
using Zoo.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Zoo.Controllers
{
    [ApiController]
    [Route("zoo/api/")]
    public class ZoneController : Controller
    {
        public ZoneController() { }

        [HttpGet("zone")]
        public async Task<IActionResult> GetZones()
        {
            ZoneDTO zone = new ZoneDTO("1", "Marina", 5000);
            return Ok(zone);
        }

        [HttpPost("zone")]
        public async Task<IActionResult> AddZones(ZoneDTO zone)
        {
            MZone mZone = new MZone();
            return Ok(mZone.AddZone(zone));
        }

        [HttpPut("zone/{id}")]
        public async Task<IActionResult> UpdateZone(int id, ZoneUpdateDTO zoneUpdate)
        {
            MZone mZone = new MZone();
            return Ok(mZone.UpdateZone(id, zoneUpdate));
        }

        [HttpDelete("zone/{id}")]
        public async Task<IActionResult> DeleteZone(int id)
        {
            MZone mZone = new MZone();
            return Ok(mZone.DeleteZone(id));
        }

    }
}