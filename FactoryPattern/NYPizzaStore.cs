namespace FactoryPattern
{
    internal class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (type == "cheese")
            {                
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "New York Style Cheese Pizza";
            }
            else if (type == "pepperoni")
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.Name = "New York Style Pepperoni Pizza";
            }
            else if (type == "clam")
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.Name = "New York Style Clam Pizza";
            }
            else if (type == "veggie")
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.Name = "New York Style Veggie Pizza";
            }
            
            return pizza;
        }
    }
}
