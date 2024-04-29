namespace AbstractFactoryPattern
{
    internal class DatabaseManager
    {
        private readonly ICommand command;
        private readonly IConnection connection;
        public DatabaseManager(IDatabaseFactory databaseFactory)
        {
            databaseFactory = databaseFactory ?? throw new ArgumentNullException(nameof(databaseFactory));
            connection = databaseFactory.CreateConnection();
            command = databaseFactory.CreateCommand();
        }

        public void PerformOperation(string query) 
        {
            connection.Connect();
            command.Execute(query);
        }
    }
}
