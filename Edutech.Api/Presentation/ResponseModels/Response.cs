namespace Edutech.Api.Presentation.ResponseModels;

public class Response(bool success, string message, object data = null!, string[] errors = null!)
{
    public bool Success { get; init; } = success;
    public string Message { get; init; } = message;
    public object Data { get; init; } = data;
    public string[] Errors { get; init; } = errors;
}
