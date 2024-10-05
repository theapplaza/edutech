using System;
using Edutech.Api.Infrastructure.Data;

namespace Edutech.Api.Presentation.ResponseModels;

public class GetCoursesResponse : Response
{
    public GetCoursesResponse(bool success, string message, IEnumerable<Course>? data = null, string[]? errors = null) : base(success, message, data, errors)
    {
        if (data is not null)
        {
            Data = new
            {
                Courses = data.Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Description,
                })
            };
        }  
    }
}
