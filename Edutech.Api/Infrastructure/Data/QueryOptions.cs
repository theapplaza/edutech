using System;
using System.Collections.Generic;

namespace Edutech.Api.Infrastructure.Data;

public class QueryOptions<T> where T : class
{
    private List<string>_includes = new List<string>();

    public List<string> Includes
    {
        get => _includes;
        set => _includes = value;
    }

}
