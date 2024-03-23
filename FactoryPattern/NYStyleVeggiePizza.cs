namespace FactoryPattern
{
    public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            _name = "NY Style Veggie Pizza";
            _dough = "Thin Crust Dough";
            _sauce = "Marinara Sauce";

            _toppings.Add("Greated Reggiano Cheese");
        }
    }
}
