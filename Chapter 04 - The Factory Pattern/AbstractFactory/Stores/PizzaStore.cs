using System;
using System.IO;
using Chapter_04___The_Factory_Pattern.AbstractFactory.Products.Pizzas;

namespace Chapter_04___The_Factory_Pattern.AbstractFactory
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(TextWriter textWriter, string type)
        {
            var pizza = CreatePizza(type);;

            pizza.Prepare(textWriter);
            // textWriter.WriteLine(pizza.Bake());
            // textWriter.WriteLine(pizza.Cut());
            // textWriter.WriteLine(pizza.Box());
            
            return pizza;
        }
        
        protected abstract Pizza CreatePizza(string type);
        
    }
}