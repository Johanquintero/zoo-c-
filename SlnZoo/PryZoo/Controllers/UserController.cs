using Microsoft.AspNetCore.Mvc;
using Zoo.DTO;

namespace Zoo.Controllers
{
    [ApiController]
    [Route("zoo-api/")]
    public class UserController : Controller
    {
        public UserController() { }

        [HttpGet("get-user")]
        public async Task<IActionResult> GetUsers()
        {
            UserTypeDTO user_type = new UserTypeDTO(1, "cuidador");
            UserDTO user = new UserDTO(1, "jesus", "sancancio", "3215841916", DateTime.Now, user_type);
            return Ok(user);
        }

    }
}