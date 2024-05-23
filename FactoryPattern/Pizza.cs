using System;
using System.Collections.Generic;

namespace FactoryPattern
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        protected IDough _dough;
        protected ISauce _sauce;
        IVeggies[] _veggies;
        protected ICheese _cheese;
        protected IPepperoni _pepperoni;
        protected IClams _clams;

        public virtual void Prepare() { }

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
    }
}
