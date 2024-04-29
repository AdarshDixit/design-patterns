namespace AbstractFactoryPattern
{
    public class OracleCommand : ICommand
    {
        public void Execute(string command)
        {
            Console.WriteLine("Execute oracle command: "  + command);
        }
    }
}
