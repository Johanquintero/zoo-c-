using Microsoft.AspNetCore.Mvc;
using Universidad.DTO;

namespace Universidad.Controllers
{
    [ApiController]
    [Route("apiuniversidad/")]
    public class UniversidadController : Controller
    {
        public UniversidadController() { }

        [HttpGet("getdepartments")]
        public async Task<IActionResult> GetDepartments()
        {
            DepartmentDTO department = new DepartmentDTO("1", "Ingenieria");
            CourseDTO course = new CourseDTO("2", "Programación", 3, department);
            return Ok(course);
        }

    }
}