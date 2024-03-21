namespace FactoryPattern
{
    public class PizzaStore
    {
        SimpleFactoryPizza factory;

        public PizzaStore(SimpleFactoryPizza factoryPizza)
        {
            factory = factoryPizza;
        }

        public IPizza OrderPizza(string type)
        {
            IPizza pizza;

            pizza = factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
