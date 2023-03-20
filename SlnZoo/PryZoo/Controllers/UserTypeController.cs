using Microsoft.AspNetCore.Mvc;
using Zoo.DTO;
using Zoo.Models;

namespace Zoo.Controllers
{
    [ApiController]
    [Route("zoo-api/")]
    public class UserTypeController : Controller
    {
        public UserTypeController() { }

        [HttpGet("get-user-types")]
        public async Task<IActionResult> GetUserTypes()
        {
            UserTypeDTO userType = new UserTypeDTO("1","Cuidador");
            return Ok(userType);
        }

       [HttpPost("add-user-type")]
        public async Task<IActionResult> AddUserType(UserTypeDTO userType)
        {
            MUserType mUserType = new MUserType();
            return Ok(mUserType.AddUserType(userType));
        }

    }
}