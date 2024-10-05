using System;
using Edutech.Api.Infrastructure.Data;

namespace Edutech.Api.Presentation.ResponseModels;

public class GetCourseResponse : Response
{

    public GetCourseResponse(bool success, string message, Course? data = null, string[]? errors = null) : base(success, message, data, errors)
    {
        if (data is null)
        {
            return;
        }

        Data = new
        {
            Course = new
            {
                data.Id,
                data.Name,
                data.Description,
                Modules = data.Modules?.Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Description,
                    Contents = x.Contents?.Select(y => new
                    {
                        y.Id,
                        y.Title
                    })
                })
            }
        };

    }
}
