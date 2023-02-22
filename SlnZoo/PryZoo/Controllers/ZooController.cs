using Microsoft.AspNetCore.Mvc;
// using Zoo.DTO;

namespace Universidad.Controllers
{
    [ApiController]
    [Route("zoo-api/")]
    public class ZooController : Controller
    {
        public ZooController() { }

        // [HttpGet("getdepartments")]
        // public async Task<IActionResult> GetDepartments()
        // {
        //     DepartmentDTO department = new DepartmentDTO("1", "Ingenieria");
        //     CourseDTO course = new CourseDTO("2", "Programación", 3, department);
        //     return Ok(course);
        // }

    }
}