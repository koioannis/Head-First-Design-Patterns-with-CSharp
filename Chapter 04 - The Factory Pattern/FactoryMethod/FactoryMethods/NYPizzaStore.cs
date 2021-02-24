using Chapter_04___The_Factory_Pattern.FactoryMethod.Products;

namespace Chapter_04___The_Factory_Pattern.FactoryMethod.FactoryMethods
{
    public class NyPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
                return new NYStyleCheesePizza();

            if (type.Equals("clam"))
                return new NYStyleClamPizza();

            if (type.Equals("pepperoni"))
                return new NYStylePepperoniPizza();

            return null;
        }
    }
}