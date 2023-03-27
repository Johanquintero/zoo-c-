using Microsoft.AspNetCore.Mvc;
using Zoo.DTO;
using Zoo.Models;

namespace Zoo.Controllers
{
    [ApiController]
    [Route("zoo-api/")]
    public class SpecieController : Controller
    {
        public SpecieController() { }

        [HttpGet("get-species")]
        public async Task<IActionResult> GetSpecies()
        {
            // SpecieDTO Specie = new SpecieDTO("1","Marina",5000);
            return Ok(1);
        }

        [HttpPost("add-specie")]
        public async Task<IActionResult> AddSpecies(SpecieDTO Specie)
        {
            MSpecie mSpecie = new MSpecie();
            return Ok(mSpecie.AddSpecie(Specie));
        }

        [HttpPut("update-specie/{id}")]
        public async Task<IActionResult> UpdateSpecie(int id, SpecieUpdateDTO specieUpdate)
        {
            MSpecie mSpecie = new MSpecie();
            return Ok(mSpecie.UpdateSpecie(id, specieUpdate));
        }

        [HttpDelete("delete-specie/{id}")]
        public async Task<IActionResult> DeleteSpecie(int id)
        {
            MSpecie mSpecie = new MSpecie();
            return Ok(mSpecie.DeleteSpecie(id));
        }
    }
}