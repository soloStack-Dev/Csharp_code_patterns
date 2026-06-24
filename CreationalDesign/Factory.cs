namespace CreationalDesign
{
    public class Factory
    {
        static void Main(string[] args)
        {
            EmailNotification emailNotification = new EmailNotification();
            emailNotification.Send();

            INotification notification = NotificationFactory.CreateNotification("Email");
            notification.Sends();
        }
    }


//without factory pattern
public class EmailNotification
{
    public void Send()
    {
        Console.WriteLine("Sending email notification");
    }
}

//with factory pattern
public interface INotification
    {
        void Sends();
    }

    public class EmailNotifications : INotification
    {
        public void Sends()
        {
            Console.WriteLine("Sending email notification");
        }
    }

    public class SmsNotifications : INotification
    {
        public void Sends()
        {
            Console.WriteLine("Sending sms notification");
        }
    }

    public class WhatsAppNotifications : INotification
    {
        public void Sends()
        {
            Console.WriteLine("Sending whatsapp notification");
        }
    }

    public class NotificationFactory
    {
        public static INotification CreateNotification(string notificationType)
        {
            if(notificationType == "Email")
            {
                return new EmailNotifications();
            }
            else if(notificationType == "Sms")
            {
                return new SmsNotifications();
            }
            else if(notificationType == "WhatsApp")
            {
                return new WhatsAppNotifications();
            }
            else
            {
                throw new ArgumentException("Invalid notification type");
            }
        }
    }

}