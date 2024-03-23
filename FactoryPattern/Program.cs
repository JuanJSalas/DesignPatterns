using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Program
    {
        /*  Factory Pattern
         * 
            Defines an interface for creating an object, but lets the subclasses
            decide which class to instantiate. Factory method lets a class defer
            instatiation to subclasses.
        */

        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Liam ordered a {pizza.GetName()} \n");

            pizza = chicagoStore.OrderPizza("pepperoni");
            Console.WriteLine($"Dario ordered a {pizza.GetName()} \n");
        }
    }
}
