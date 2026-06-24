namespace DesignPatters
{
    public class DependencyInversion
    {
        static void Main(String[] args)
        {
            EmailServices emailServices = new EmailServices();
            UserServices userServices = new UserServices(emailServices);
            userServices.RegisterUser();

            IMessageServices mailServices = new EmailService();
            UserService userService = new UserService(mailServices);
            userService.RegisterUser();
        }
    }
}

public class EmailServices
{
    public void SendEmail(string message)
    {
        Console.WriteLine($"Sending email: {message}");
    }
}

public class UserServices
{
    private EmailServices _emailServices;

    public UserServices(EmailServices emailServices)
    {
        _emailServices = emailServices;
    }
    //now day comapnie say to create email service to send email to user
    //suppose companie say to create sms service to send sms to user it stuck changes UserServices class
    //so we use Dependency Inversion Principle to solve this problem

    public void RegisterUser()
    {
        Console.WriteLine("User Registered");
        _emailServices.SendEmail("Welcome to our platform!");
    }
}

public interface IMessageServices
{
    void Send(string message);
}

public class EmailService : IMessageServices
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending email: {message}");
    }
}

public class SmsService : IMessageServices
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending sms: {message}");
    }
}

public class UserService
{
    private readonly IMessageServices _messageServices;
    public UserService(IMessageServices messageServices)
    {
        _messageServices = messageServices;
    }
    public void RegisterUser()
    {
        Console.WriteLine("User Registered");
        _messageServices.Send("Welcome!");
    }
}