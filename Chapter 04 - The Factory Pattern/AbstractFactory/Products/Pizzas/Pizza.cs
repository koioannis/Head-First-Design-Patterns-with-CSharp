using System.IO;
using Chapter_04___The_Factory_Pattern.AbstractFactory.Products.Ingredients;

namespace Chapter_04___The_Factory_Pattern.AbstractFactory.Products.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; set; }

        protected IDough Dough { get; set; }
        protected ISauce Sause { get; set; }
        protected ICheese Cheese { get; set; }
        
        protected IPepperoni Pepperoni { get; set; }
        
        protected IClams Clams { get; set; }

        public abstract void Prepare(TextWriter textWriter);

        public string Bake()
        {
            return "Bake for 25 minutes at 350";
        }

        public string Cut()
        {
            return "Cutting the pizza into diagonal slices";
        }

        public string Box()
        {
            return "Place pizza in official PizzaStore box";
        }
    }
}