using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class SQLConnection : IConnection
    {
        public string Connect()
        {
            Console.WriteLine("Connected to SQL");
            return "SQLConnection";
        }
    }
}
