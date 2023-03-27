using Microsoft.AspNetCore.Mvc;
using Zoo.DTO;
using Zoo.Models;

namespace Zoo.Controllers
{
    [ApiController]
    [Route("zoo/api/")]
    public class SpecieHabitatController : Controller
    {
        public SpecieHabitatController() { }

        [HttpGet("specie-habitat")]
        public async Task<IActionResult> GetSpecieHabitats()
        {
            // SpecieHabitatDTO SpecieHabitat = new SpecieHabitatDTO("1","Marina",5000);
            return Ok(1);
        }

        [HttpPost("specie-habitat")]
        public async Task<IActionResult> AddSpecieHabitats(SpecieHabitatDTO SpecieHabitat)
        {
            MSpecieHabitat mSpecieHabitat = new MSpecieHabitat();
            return Ok(mSpecieHabitat.AddSpecieHabitat(SpecieHabitat));
        }
        [HttpPut("specie-habitat/{id}")]
        public async Task<IActionResult> UpdateSpecieHabitat(int id, SpecieHabitatUpdateDTO specieHabitatUpdate)
        {
            MSpecieHabitat mSpecieHabitat = new MSpecieHabitat();
            return Ok(mSpecieHabitat.UpdateSpecieHabitat(id, specieHabitatUpdate));
        }

        [HttpDelete("specie-habitat/{id}")]
        public async Task<IActionResult> DeleteSpecieHabitat(int id)
        {
            MSpecieHabitat mSpecieHabitat = new MSpecieHabitat();
            return Ok(mSpecieHabitat.DeleteSpecieHabitat(id));
        }
    }
}