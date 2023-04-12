using Microsoft.AspNetCore.Mvc;
using Zoo.DTO;
using Zoo.Models;

namespace Zoo.Controllers
{
    [ApiController]
    [Route("zoo/api/")]
    public class VegetationTypeController : Controller
    {
        public VegetationTypeController() { }

        [HttpGet("vegetation-type/{id}")]
        public async Task<IActionResult> GetVegetationTypes(int id = 0)
        {
            MVegetationType MVegetationType = new MVegetationType();
            return Ok(MVegetationType.GetVegetationType(id));
        }

        [HttpPost("vegetation-type")]
        public async Task<IActionResult> AddVegetationType(VegetationTypeDTO vegetationType)
        {
            MVegetationType mVegetationType = new MVegetationType();
            return Ok(mVegetationType.AddVegetationType(vegetationType));
        }

        [HttpPut("vegetation-type/{id}")]
        public async Task<IActionResult> UpdateVegetationType(int id, VegetationTypeUpdateDTO vtUptade)
        {
            MVegetationType mVegetationType = new MVegetationType();
            return Ok(mVegetationType.UpdateVegetationType(id, vtUptade));
        }

        [HttpDelete("vegetation-type/{id}")]
        public async Task<IActionResult> DeleteVegetationType(int id)
        {
            MVegetationType mVT = new MVegetationType();
            return Ok(mVT.DeleteVegetationType(id));
        }

    }
}