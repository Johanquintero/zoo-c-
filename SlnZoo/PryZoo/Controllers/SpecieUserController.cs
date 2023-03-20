using Microsoft.AspNetCore.Mvc;
using Zoo.DTO;
using Zoo.Models;

namespace Zoo.Controllers
{
    [ApiController]
    [Route("zoo-api/")]
    public class SpecieUserController : Controller
    {
        public SpecieUserController() { }

        [HttpGet("get-specie-users")]
        public async Task<IActionResult> GetSpecieUsers()
        {
            // SpecieUserDTO SpecieUser = new SpecieUserDTO("1","Marina",5000);
            return Ok(1);
        }

        [HttpPost("add-specie-user")]
        public async Task<IActionResult> AddSpecieUsers(SpecieUserDTO SpecieUser)
        {
            MSpecieUser mSpecieUser = new MSpecieUser();
            return Ok(mSpecieUser.AddSpecieUser(SpecieUser));
        }
    }
}