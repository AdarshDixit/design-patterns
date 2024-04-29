namespace FactoryMethodPattern
{
    internal class EmailNotifierFactory : NotifierFactory
    {
        public override INotifier GenerateNotifier()
        {
            return new EmailNotifier();
        }
    }
}
