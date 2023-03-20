using Microsoft.AspNetCore.Mvc;
using Zoo.DTO;
using Zoo.Models;

namespace Zoo.Controllers
{
    [ApiController]
    [Route("zoo-api/")]
    public class HabitatController : Controller
    {
        public HabitatController() { }

        [HttpGet("get-habitats")]
        public async Task<IActionResult> GetHabitats()
        {
            // HabitatDTO Habitat = new HabitatDTO("1","Marina","calido");
            return Ok(1);
        }

        [HttpPost("add-habitat")]
        public async Task<IActionResult> AddHabitats(HabitatDTO Habitat)
        {
            MHabitat Mhabitat = new MHabitat();
            return Ok(Mhabitat.AddHabitat(Habitat));
        }
    }
}