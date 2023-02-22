using Microsoft.AspNetCore.Mvc;
using Zoo.DTO;

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
            ZoneDTO zone = new ZoneDTO(1,"Marina",5000);
            return Ok(zone);
        }

    }
}