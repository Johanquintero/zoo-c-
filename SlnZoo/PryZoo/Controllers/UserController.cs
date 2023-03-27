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

        [HttpGet("user")]
        public async Task<IActionResult> GetUsers()
        {
            // UserDTO User = new UserDTO("1","Marina",5000);
            return Ok(1);
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