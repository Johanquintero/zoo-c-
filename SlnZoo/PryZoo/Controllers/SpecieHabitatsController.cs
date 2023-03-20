using Microsoft.AspNetCore.Mvc;
using Zoo.DTO;
using Zoo.Models;

namespace Zoo.Controllers
{
    [ApiController]
    [Route("zoo-api/")]
    public class SpecieHabitatController : Controller
    {
        public SpecieHabitatController() { }

        [HttpGet("get-specie-habitats")]
        public async Task<IActionResult> GetSpecieHabitats()
        {
            // SpecieHabitatDTO SpecieHabitat = new SpecieHabitatDTO("1","Marina",5000);
            return Ok(1);
        }

        [HttpPost("add-specie-habitat")]
        public async Task<IActionResult> AddSpecieHabitats(SpecieHabitatDTO SpecieHabitat)
        {
            MSpecieHabitat mSpecieHabitat = new MSpecieHabitat();
            return Ok(mSpecieHabitat.AddSpecieHabitat(SpecieHabitat));
        }
    }
}