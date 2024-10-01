using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Edutech.Api.Presentation
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CourseController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCourses()
        {
            return Ok("Courses returned");
        }
    }
}
