using System.Xml.XPath;
using Chapter_04___The_Factory_Pattern.AbstractFactory.Factory;
using Chapter_04___The_Factory_Pattern.AbstractFactory.Products.Pizzas;
using Chapter_04___The_Factory_Pattern.FactoryMethod.FactoryMethods;

namespace Chapter_04___The_Factory_Pattern.AbstractFactory
{
    public class NyPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            var nyPizzaIngredientFactory = new NyPizzaIngredientFactory();

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(nyPizzaIngredientFactory);
                pizza.Name = "New York Style Cheese Pizza";
            }

            return pizza;
        }
    }
}