using System;
using System.Linq.Expressions;
using Edutech.Api.Infrastructure.Data;

namespace Edutech.Api.Application.Services;

public class CourseService
{
    private readonly IRepository<Course> _repository;

    public CourseService(IRepository<Course> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Course>> GetCourses()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Course> GetCourse(Guid id)
    {
        return await _repository.GetByIdAsync(id, new QueryOptions<Course>
        {
            Includes = new List<string>
            {
                $"{nameof(Course.Modules)}"
            }
        });
    }
}
