using Microsoft.AspNetCore.Mvc;
using Zoo.DTO;
using Zoo.Models;

namespace Zoo.Controllers
{
    [ApiController]
    [Route("zoo/api/")]
    public class UserTypeController : Controller
    {
        public UserTypeController() { }

        [HttpGet("user-type/{id}")]
        public async Task<IActionResult> GetUserTypes(int id = 0)
        {
            MUserType MUserType = new MUserType();
            return Ok(MUserType.GetUserType(id));
        }

       [HttpPost("user-type")]
        public async Task<IActionResult> AddUserType(UserTypeDTO userType)
        {
            MUserType mUserType = new MUserType();
            return Ok(mUserType.AddUserType(userType));
        }

         [HttpPut("user-type/{id}")]
        public async Task<IActionResult> UpdateUserType(int id, UserTypeDTO userType)
        {
            MUserType mUserType = new MUserType();
            return Ok(mUserType.UpdateUserType(id, userType));
        }


        [HttpDelete("user-type/{id}")]
        public async Task<IActionResult> DeleteUserType(int id)
        {
            MUserType mUserType = new MUserType();
            return Ok(mUserType.DeleteUserType(id));
        }

    }
}