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
    }
}