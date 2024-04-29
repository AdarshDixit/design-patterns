// See https://aka.ms/new-console-template for more information
using AbstractFactoryPattern;
/*
*Product A: SQL
*Product B: Oracle
*Product 1: Connection
*Product 2: Command
*AbstractFactory
*Concrete1: SQLFactory: A1, A2
*Concrete2: OracleFactory: B1, B2
 */


Console.WriteLine("----------------------------------SQL---------------------------------------");
Console.WriteLine("\n");

var sql = new SQLServerFactory();
DatabaseManager manager = new DatabaseManager(sql);
manager.PerformOperation("SELECT * FROM [TABLE]");

Console.WriteLine("\n");
Console.WriteLine("----------------------------------ORACLE---------------------------------------");
Console.WriteLine("\n");

var oracle = new OracleFactory();
DatabaseManager manager2 = new DatabaseManager(oracle);
manager2.PerformOperation("SELECT * FROM [TABLE]");

Console.WriteLine("\n");
Console.WriteLine("----------------------------------END---------------------------------------");