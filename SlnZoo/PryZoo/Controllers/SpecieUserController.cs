using Microsoft.AspNetCore.Mvc;
using Zoo.DTO;
using Zoo.Models;

namespace Zoo.Controllers
{
    [ApiController]
    [Route("zoo/api/")]
    public class SpecieUserController : Controller
    {
        public SpecieUserController() { }

        [HttpGet("specie-user")]
        public async Task<IActionResult> GetSpecieUsers()
        {
            MSpecieUser MSpecieUser = new MSpecieUser();
            return Ok(MSpecieUser.GetSpecieUsers());
        }

        [HttpPost("specie-user")]
        public async Task<IActionResult> AddSpecieUsers(SpecieUserDTO SpecieUser)
        {
            MSpecieUser mSpecieUser = new MSpecieUser();
            return Ok(mSpecieUser.AddSpecieUser(SpecieUser));
        }

         [HttpPut("specie-user/{id}")]
        public async Task<IActionResult> UpdateSpecieUsers(int id, SpecieUserUpdateDTO specieUserUpdateDTO)
        {
            MSpecieUser mSpecieUser = new MSpecieUser();
            return Ok(mSpecieUser.UpdateSpecieUsers(id, specieUserUpdateDTO));
        }

        [HttpDelete("pecie-user/{id}")]
        public async Task<IActionResult> DeleteSpecieUsers(int id)
        {
            MSpecieUser mSpecieUser = new MSpecieUser();
            return Ok(mSpecieUser.DeleteSpecieUsers(id));
        }
    }
}