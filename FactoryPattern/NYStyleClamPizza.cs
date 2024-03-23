using System;

namespace FactoryPattern
{
    public class NYStyleClamPizza : Pizza
    {
        public NYStyleClamPizza()
        {
            _name = "NY Style Clam Pizza";
            _dough = "Thin Crust Dough";
            _sauce = "Marinara Sauce";

            _toppings.Add("Greated Reggiano Cheese");
        }
    }
}
