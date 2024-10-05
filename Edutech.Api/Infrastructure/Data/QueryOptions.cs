namespace Edutech.Api.Infrastructure.Data;

public class QueryOptions<T> where T : class
{
    private List<string>_includes = [];

    public List<string> Includes
    {
        get => _includes;
        set => _includes = value;
    }

}
