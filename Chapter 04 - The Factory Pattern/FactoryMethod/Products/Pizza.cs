using System;
using System.Collections.Generic;

namespace Chapter_04___The_Factory_Pattern.FactoryMethod.Products
{
    public abstract class Pizza
    {
        public string Name  { get; protected set; }
        public string Dough { get; protected set; }
        public string Sauce { get; protected set; }
        public List<string> Toppings { get; } = new List<string>();

        public string Prepare()
        {
            return $"Preparing {Name}";
        }

        public string Bake()
        {
            return "Bake for 25 minutes at 350";
        }

        public virtual string Cut()
        {
            return "Cutting the pizza into diagonal slices";
        }

        public string Box()
        {
            return "Place pizza in official PizzaStore box";
        }
    }
}