using System.IO;
using Chapter_04___The_Factory_Pattern.AbstractFactory.Factory;
using Chapter_04___The_Factory_Pattern.AbstractFactory.Products.Pizzas;

namespace Chapter_04___The_Factory_Pattern.AbstractFactory
{
    public class CheesePizza : Pizza
    {
        private readonly IPizzaIngedientFactory _ingredientFactory;

        public CheesePizza(IPizzaIngedientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare(TextWriter textWriter)
        {
            textWriter.WriteLine($"Preparing {Name}");

            Dough = _ingredientFactory.CreateDough();
            Sause = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
            
            textWriter.WriteLine($"Adding {Dough.ToString()}");
            textWriter.WriteLine($"Adding {Sause.ToString()}");
            textWriter.WriteLine($"Adding {Cheese.ToString()}");
        }
    }
}

