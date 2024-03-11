using System;

namespace DecoratorPattern
{
    internal class Program
    {
        /*  Decorator Pattern
         * 
            Attaches additional resposibilites to an object dynamically.
            Decorators provide a flexible alternative to
            subclassing for extending functionality.
        */

        static void Main(string[] args)
        {
            Beverage beverage = new Expresso(Beverage.Size.VENTI);
            Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");

            Console.WriteLine();

            Beverage beverage2 = new DarkRoast(Beverage.Size.TALL);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine($"{beverage2.GetDescription()} ${beverage2.Cost()}");

            Console.WriteLine();


            Beverage beverage3 = new HouseBlend(Beverage.Size.GRANDE);
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine($"{beverage3.GetDescription()} ${beverage3.Cost()}");

            Console.WriteLine();
        }
    }
}
