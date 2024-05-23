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
            The PizzaStore (has a Factory Method) abstract class.
        */

        /* Abstract Factory Pattern
         * 
            Provides an interface for creating families of related or dependent
            objects without specifiyng the concrete classes.
            The IPizzaIngredientFactory interface.
        */

        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Liam ordered a {pizza.Name} \n");

            pizza = chicagoStore.OrderPizza("pepperoni");
            Console.WriteLine($"Dario ordered a {pizza.Name} \n");
        }
    }
}
                                                                                        