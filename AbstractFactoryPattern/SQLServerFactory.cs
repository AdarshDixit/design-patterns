namespace AbstractFactoryPattern
{
    public class SQLServerFactory : IDatabaseFactory
    {
        public IConnection CreateConnection()
        {
            return new SQLConnection();
        }

        public ICommand CreateCommand()
        {
            return new SQLCommand();
        }
    }
}
