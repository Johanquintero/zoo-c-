using Microsoft.AspNetCore.Mvc;
using Zoo.DTO;
using Zoo.Models;

namespace Zoo.Controllers
{
    [ApiController]
    [Route("zoo/api/")]
    public class HabitatController : Controller
    {
        public HabitatController() { }

        [HttpGet("habitat")]
        public async Task<IActionResult> GetHabitats()
        {
            MHabitat MHabitat = new MHabitat();
            return Ok(MHabitat.GetHabitat());
        }

        [HttpPost("habitat")]
        public async Task<IActionResult> AddHabitats(HabitatDTO Habitat)
        {
            MHabitat Mhabitat = new MHabitat();
            return Ok(Mhabitat.AddHabitat(Habitat));
        }
        [HttpPut("habitat/{id}")]
        public async Task<IActionResult> UpdateHabitat(int id, HabitatUpdateDTO habitatUpdate)
        {
            MHabitat mHabitat = new MHabitat();
            return Ok(mHabitat.UpdateHabitat(id, habitatUpdate));
        }

        [HttpDelete("habitat/{id}")]
        public async Task<IActionResult> DeleteHabitat(int id)
        {
            MHabitat mHabitat = new MHabitat();
            return Ok(mHabitat.DeleteHabitat(id));
        }
    }
}