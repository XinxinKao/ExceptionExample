using ExceptionExample.Enums;

namespace ExceptionExample.Exceptions;

public class UserNotFoundException : Exception
{
    public ErrorCode ErrorCode { get; set; }
    public string ErrorMessage { get; set; }

    public UserNotFoundException(ErrorCode errorCode, string errorMessage)
    {
        ErrorCode = errorCode;
        ErrorMessage = errorMessage;
    }
}