using Chapter_04___The_Factory_Pattern.FactoryMethod.Products;

namespace Chapter_04___The_Factory_Pattern.FactoryMethod.FactoryMethods
{
    public class ChicagoPizzaStore : PizzaStore 
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
                return new ChicagoStyleCheesePizza();

            if (type.Equals("clam"))
                return new ChicagoStyleClamPizza();

            if (type.Equals("pepperoni"))
                return new ChicagoStylePepperoniPizza();

            return null;
        }
    }
} 