using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class OracleConnection : IConnection
    {
        public string Connect()
        {
            Console.WriteLine("Connected to oracle");
            return "OracleConnection";
        }
    }
}
