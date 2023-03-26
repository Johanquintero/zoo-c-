using Microsoft.AspNetCore.Mvc;
using Zoo.DTO;
using Zoo.Models;

namespace Zoo.Controllers
{
    [ApiController]
    [Route("zoo-api/")]
    public class VegetationTypeController : Controller
    {
        public VegetationTypeController() { }

        [HttpGet("get-vegetation-types")]
        public async Task<IActionResult> GetVegetationTypes()
        {
            VegetationTypeDTO vT = new VegetationTypeDTO("1", "Marina", "asdasd");
            return Ok(vT);
        }

        [HttpPost("add-vegetation-type")]
        public async Task<IActionResult> AddVegetationType(VegetationTypeDTO vegetationType)
        {
            MVegetationType mVegetationType = new MVegetationType();
            return Ok(mVegetationType.AddVegetationType(vegetationType));
        }

        [HttpPut("update-vegetation-type/{id}")]
        public async Task<IActionResult> UpdateVegetationType(int id, VegetationTypeUpdateDTO vtUptade)
        {
            MVegetationType mVegetationType = new MVegetationType();
            return Ok(mVegetationType.UpdateVegetationType(id, vtUptade));
        }

        [HttpDelete("delete-vegetation-type/{id}")]
        public async Task<IActionResult> DeleteVegetationType(int id)
        {
            MVegetationType mVT = new MVegetationType();
            return Ok(mVT.DeleteVegetationType(id));
        }

    }
}