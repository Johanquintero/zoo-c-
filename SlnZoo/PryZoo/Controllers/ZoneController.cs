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

        [HttpGet("zone/{id}")]
        public async Task<IActionResult> GetZones(int id = 0)
        {
            MZone MZone = new MZone();
            return Ok(MZone.GetZone(id));
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