using System;
using System.Collections.Generic;

namespace FactoryPattern
{
    public abstract class Pizza
    {
        protected string _name;
        protected string _dough;
        protected string _sauce;
        protected List<string> _toppings = new List<string>();


        public virtual void Prepare() 
        {
            Console.WriteLine($"Preparing {_name}");
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings:");
            foreach( string p in _toppings ) Console.WriteLine($"   {p}");
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string GetName()
        {
            return _name;
        }
    }
}
