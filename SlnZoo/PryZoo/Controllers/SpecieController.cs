using Microsoft.AspNetCore.Mvc;
using Zoo.DTO;
using Zoo.Models;

namespace Zoo.Controllers
{
    [ApiController]
    [Route("zoo/api/")]
    public class SpecieController : Controller
    {
        public SpecieController() { }

        [HttpGet("specie")]
        public async Task<IActionResult> GetSpecies()
        {
            MSpecie MSpecie = new MSpecie();
            return Ok(MSpecie.GetSpecie());
        }

        [HttpPost("specie")]
        public async Task<IActionResult> AddSpecies(SpecieDTO Specie)
        {
            MSpecie mSpecie = new MSpecie();
            return Ok(mSpecie.AddSpecie(Specie));
        }

        [HttpPut("specie/{id}")]
        public async Task<IActionResult> UpdateSpecie(int id, SpecieUpdateDTO specieUpdate)
        {
            MSpecie mSpecie = new MSpecie();
            return Ok(mSpecie.UpdateSpecie(id, specieUpdate));
        }

        [HttpDelete("specie/{id}")]
        public async Task<IActionResult> DeleteSpecie(int id)
        {
            MSpecie mSpecie = new MSpecie();
            return Ok(mSpecie.DeleteSpecie(id));
        }
    }
}