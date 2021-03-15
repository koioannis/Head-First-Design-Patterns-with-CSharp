using System;

namespace Chapter_09___The_Iterator_and_Composite_Patterns.The_Iterator_Pattern
{
    public class MenuItem
    {
        public string Name { get; private set; }

        public string Description { get; private set; }

        public bool IsVegetarian { get; private set; }

        public double Price { get; private set; }

        public MenuItem(string name, string description, bool isVegetarian, double price)
        {
            Name = name;
            Description = description;
            IsVegetarian = isVegetarian;
            Price = price;
        }
    }
}