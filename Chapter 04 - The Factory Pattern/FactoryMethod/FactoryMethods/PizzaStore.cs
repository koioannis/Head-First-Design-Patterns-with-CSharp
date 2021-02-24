using System.IO;
using Chapter_04___The_Factory_Pattern.FactoryMethod.Products;

namespace Chapter_04___The_Factory_Pattern.FactoryMethod.FactoryMethods
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(TextWriter textWriter, string type)
        {
            var pizza = CreatePizza(type);;

            textWriter.WriteLine(pizza.Prepare());
            textWriter.WriteLine(pizza.Bake());
            textWriter.WriteLine(pizza.Cut());
            textWriter.WriteLine(pizza.Box());
            
            return pizza;
        }
        
        protected abstract Pizza CreatePizza(string type);

    }
}