using ExceptionExample.Enums;

namespace ExceptionExample.Exceptions;

public class XinyiException : Exception
{
    public ErrorCode ErrorCode { get; set; }
    public string ErrorMessage { get; set; }

    public XinyiException(ErrorCode errorCode, string errorMessage) : base(errorMessage)
    {
        ErrorCode = errorCode;
        ErrorMessage = errorMessage;
    }
    
    public XinyiException(ErrorCode errorCode, string errorMessage, Exception innerException) : base(errorMessage, innerException)
    {
        ErrorCode = errorCode;
        ErrorMessage = errorMessage;
    }
}