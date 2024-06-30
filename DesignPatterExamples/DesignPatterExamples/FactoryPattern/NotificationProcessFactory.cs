using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterExamples.FactoryPattern
{
    public enum NotificationType
    {
        Email,
        SMS,
        Push
    }
    internal class NotificationProcessFactory
    {
        INotification notification = null;
        public INotification CreateNotification(NotificationType type)
        {
            switch (type)
            {
                case NotificationType.Email:
                    notification= new EmailNotification();break;
                case NotificationType.SMS:
                    notification= new SMSNotification(); break;
                case NotificationType.Push:
                    notification= new PushNotification(); break;
                default:
                    throw new NotSupportedException($"Notification type '{type}' is not supported.");
            }
            return notification;
        }
    }
}
