namespace FactoryPattern
{
    internal class TexasPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            if (type == "cheese")
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "Texas Style Cheese Pizza";
            }
            else if (type == "pepperoni")
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.Name = "Texas Style Pepperoni Pizza";
            }
            else if (type == "clam")
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.Name = "Texas Style Clam Pizza";
            }
            else if (type == "veggie")
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.Name = "Texas Style Veggie Pizza";
            }

            return pizza;
        }
    }
}
