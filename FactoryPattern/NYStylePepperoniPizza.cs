using System;

namespace FactoryPattern
{
    public class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza()
        {
            _name = "NY Style Pepperoni Pizza";
            _dough = "Thin Crust Dough";
            _sauce = "Marinara Sauce";

            _toppings.Add("Greated Reggiano Cheese");
        }
    }
}
