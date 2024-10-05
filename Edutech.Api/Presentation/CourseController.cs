using Edutech.Api.Application.Services;
using Edutech.Api.Infrastructure.Data;
using Edutech.Api.Presentation.ResponseModels;
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
        public async Task<IActionResult> GetCourses([FromServices] CourseService service)
        {
            var data = await service.GetCourses();
            return Ok(new GetCoursesResponse(true, "Courses retrieved successfully", data));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourse([FromServices] CourseService service, Guid id)
        {
            var data = await service.GetCourse(id);
            return Ok(new GetCourseResponse(true, "Course retrieved successfully", data));
        }
    }


}
