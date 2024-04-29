namespace FactoryMethodPattern
{
    public class NotificationService
    {
        public static void Notify(NotifierFactory factory, string message)
        {
            INotifier notification = factory.GenerateNotifier();
            notification.SendNotification(message);
        }
    }
}
