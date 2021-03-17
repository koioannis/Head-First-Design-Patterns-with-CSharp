using System;
using System.Collections.Generic;

namespace Chapter_09___The_Iterator_and_Composite_Patterns.The_Composite_Pattern
{
    public class Menu : MenuComponent
    {
        public override string Name { get; }
        public override string Description { get; }

        private readonly List<MenuComponent> _menuComponents = new List<MenuComponent>();

        public Menu(string name, string description)
        {
            Description = description;
            Name = name;
        }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int index)
        {
            return _menuComponents[index];
        }

        public override void Print()
        {
            Console.Write($"\n {Name}");
            Console.WriteLine($", {Description}");
            Console.WriteLine("-------------------------");

            foreach (var component in _menuComponents)
            {
                component.Print();
            }
        }
    }
}