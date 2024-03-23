using System;

namespace FactoryPattern
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            _name = "NY Style Chesse Pizza";
            _dough = "Thin Crust Dough";
            _sauce = "Marinara Sauce";

            _toppings.Add("Greated Reggiano Cheese");
        }
    }
}
