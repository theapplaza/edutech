namespace Edutech.Api.Presentation.ResponseModels;

public class Response
{
    public bool Success { get; init; }
    public string Message { get; init; }
    public object Data { get; init; }
    public string[] Errors { get; init; }

    public Response(bool success, string message, object data = null, string[] errors = null)
    {
        Success = success;
        Message = message;
        Data = data;
        Errors = errors;
    }
}
