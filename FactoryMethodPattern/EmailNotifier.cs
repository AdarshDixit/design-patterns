using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class EmailNotifier : INotifier
    {
        public void SendNotification(string notification)
        {
            Console.WriteLine("Email notification: " + notification);
        }
    }
}
