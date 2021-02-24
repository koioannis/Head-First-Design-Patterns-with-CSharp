using System;
using Chapter_04___The_Factory_Pattern.AbstractFactory;

namespace Chapter_04___The_Factory_Pattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Factory method test
            
            // PizzaStore pizzaStore = new NyPizzaStore();
            //
            // var pizza = pizzaStore.OrderPizza(Console.Out, "clam");
            // Console.WriteLine($"Made a really tasty {pizza.Name}");
            
            // Abstract factory test

            PizzaStore pizzaStore = new NyPizzaStore();
            
            var pizza = pizzaStore.OrderPizza(Console.Out, "cheese");

        }
    }
}