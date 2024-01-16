using ExceptionExample;
using ExceptionExample.Enums;
using ExceptionExample.Exceptions;
using ExceptionExample.Services;

namespace ExceptionExampleTests;

public class ExceptionTests
{
    [Test]
    public void XinyiExceptionTest()
    {
        var exception = new XinyiException(ErrorCode.LoginFail, "Login service fail.");
        
        Assert.That(exception.ErrorMessage, Is.EqualTo("Login service fail."));
        Assert.That(exception.Message, Is.EqualTo("Login service fail."));
    }
    
    [Test]
    public void LoginServiceTest()
    {
        var loginService = new LoginService();
        
        try
        {
            loginService.Login();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
        }
    }
}