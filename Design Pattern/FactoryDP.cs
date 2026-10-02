using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern
{
    public interface INotification
    {
        void Send();
    }

    public class EmailNotification : INotification
    {
        public void Send() => Console.WriteLine("Sending Email Notification");
    }

    public class SmsNotification : INotification
    {
        public void Send() => Console.WriteLine("Sending SMS Notification");
    }

    public class PushNotification : INotification
    {
        public void Send() => Console.WriteLine("Sending Push Notification");
    }

    public class NotificationFactory
    {
        public INotification create(string type)
        {
            return type switch
            {
                "EMAIL" => new EmailNotification(),
                "SMS" => new SmsNotification(),
                "PUSH" => new PushNotification(),
                _ => throw new Exception("Invalid Notification type")
            };
        }
    }
}
