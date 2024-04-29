namespace AbstractFactoryPattern
{
    public class OracleFactory : IDatabaseFactory
    {
        public IConnection CreateConnection()
        {
            return new OracleConnection();
        }

        public ICommand CreateCommand()
        {
            return new OracleCommand();
        }
    }
}
