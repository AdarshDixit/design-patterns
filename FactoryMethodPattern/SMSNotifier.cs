namespace FactoryMethodPattern
{
    public class SMSNotifier : INotifier
    {
        public void SendNotification(string notification)
        {
            Console.WriteLine("SMS notification: " + notification);
        }
    }
}
