namespace DesignPatters
{
    public class OpenClose
    {
        static void Main(String[] args)
        {
            INotification notification = new EmailNotification();
            notification.Send();
            notification = new SmsNotification();
            notification.Send();
            notification = new WhatsappNotification();
            notification.Send();
        }
    }
}


//dont write existing code to add new feature because it will break the code.
//so we can use Open-closed Principle to add new feature with creating new class.
//so we can add new feature without breaking the code.

public interface INotification
{
    void Send();
}

public class EmailNotification : INotification
{
    public void Send()
    {
        Console.WriteLine("Sending email notification...");
    }
}

public class SmsNotification : INotification
{
    public void Send()
    {
        Console.WriteLine("Sending sms notification...");
    }
}

public class WhatsappNotification : INotification
{
    public void Send()
    {
        Console.WriteLine("Sending whatsapp notification...");
    }
}
