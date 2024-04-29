using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class SQLCommand : ICommand
    {
        public void Execute(string command)
        {
            Console.WriteLine("Execute SQL command: " + command);
        }
    }
}
