using ExceptionExample.Enums;
using ExceptionExample.Exceptions;

namespace ExceptionExample.Services;

public class LoginService
{
    public void Login()
    {
        try
        {
            //DO something
            
            throw new UserNotFoundException(ErrorCode.LoginFail, "Here is LoginFail UserNotFoundException.");
        }
        catch (UserNotFoundException userNotFoundException)
        {
            //DO user not found error handle
            
            throw new XinyiException(ErrorCode.LoginFail, "Here is LoginFail XinyiException.", userNotFoundException);
        }
        catch (XinyiException xinyiException)
        {
            //DO general error handle
            
            throw new XinyiException(ErrorCode.LoginFail, "");
        }
    }
}