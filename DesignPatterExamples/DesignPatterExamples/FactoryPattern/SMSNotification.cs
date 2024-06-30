using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterExamples.FactoryPattern
{
    internal class SMSNotification : INotification
    {
        public void SendNotification()
        {
            Console.WriteLine("Sending SMS Notification...");
        }
    }
}
