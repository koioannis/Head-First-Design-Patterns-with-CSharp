using System;

namespace Chapter_09___The_Iterator_and_Composite_Patterns.The_Composite_Pattern
{
    public class MenuItem : MenuComponent
    {
        public override string Description { get; }
        public override string Name { get; }
        public override double Price { get; }
        public override bool IsVegetarian { get; }

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            Description = description;
            Name = name;
            Price = price;
            IsVegetarian = vegetarian;
        }

        public override void Print()
        {
            Console.Write($" {Name}");
            if (IsVegetarian)
            {
                Console.Write(" (v)");
            }
            Console.WriteLine($", {Price}");
            Console.WriteLine($"-- {Description}");
        }
    }
}