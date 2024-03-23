using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            _name = "Chicago Style Veggie Pizza";
            _dough = "Extra Thick Crust Dough";
            _sauce = "Plum Tomato Sauce";

            _toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into squares");
        }
    }
}
