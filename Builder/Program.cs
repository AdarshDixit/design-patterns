// See https://aka.ms/new-console-template for more information
using Builder;

Console.WriteLine("Hello, World!");

/* Use case: Create a beverage - Either Tea/Coffee 
 * Step 1: Add water quantity
 * Step 2: Add milk quantity
 * Step 3: Add sugar quantity
 * Step 4: Add powder (tea/coffee)   
*/
Beverage beverage;
BeverageDirector beverageDirector = new BeverageDirector();

var tea = new TeaBuilder();
beverage = beverageDirector.MakeBeverage(tea);
Console.WriteLine(beverage.GetBeverage());


var coffee = new CoffeeBuilder();
beverage = beverageDirector.MakeBeverage(coffee);
Console.WriteLine(beverage.GetBeverage());
Console.ReadKey();