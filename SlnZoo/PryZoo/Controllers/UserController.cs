using Microsoft.AspNetCore.Mvc;
using Zoo.DTO;
using Zoo.Models;

namespace Zoo.Controllers
{
    [ApiController]
    [Route("zoo/api/")]
    public class UserController : Controller
    {
        public UserController() { }

        [HttpGet("user/{id}")]
        public async Task<IActionResult> GetUsers(int id = 0)
        {
            MUser MUser = new MUser();
            return Ok(MUser.GetUser(id));
        }

        [HttpPost("user")]
        public async Task<IActionResult> AddUsers(UserDTO User)
        {
            MUser mUser = new MUser();
            return Ok(mUser.AddUser(User));
        }

        [HttpPut("user/{id}")]
        public async Task<IActionResult> UpdateUser(int id, UserUpdateDTO userUpdateDTO)
        {
            MUser mUser = new MUser();
            return Ok(mUser.UpdateUser(id, userUpdateDTO));
        }

        [HttpDelete("user/{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            MUser mUser = new MUser();
            return Ok(mUser.DeleteUser(id));
        }
    }
}