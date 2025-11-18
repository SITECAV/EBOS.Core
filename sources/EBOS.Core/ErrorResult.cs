namespace EBOS.Core;

public class ErrorResult(string message, int code, string? exceptionMsg)
{
    public string? ExceptionMsg { get; set; } = exceptionMsg;
    public int Code { get; set; } = code;
    public string Message { get; set; } = message;
}
