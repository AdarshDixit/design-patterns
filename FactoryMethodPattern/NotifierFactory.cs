namespace FactoryMethodPattern
{
    public abstract class NotifierFactory
    {
        public abstract INotifier GenerateNotifier();
    }
}
