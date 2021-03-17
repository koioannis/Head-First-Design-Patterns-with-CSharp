using System;
using System.Collections.Generic;
using System.ComponentModel;
using Chapter_09___The_Iterator_and_Composite_Patterns.The_Iterator_Pattern.Iterators;

namespace Chapter_09___The_Iterator_and_Composite_Patterns.The_Iterator_Pattern.Menus
{
    public class CafeMenu : IMenu
    {
        private readonly Dictionary<String, MenuItem> _menuItems = new Dictionary<string, MenuItem>();

        public CafeMenu()
        {
            AddItem(
                "Veggie Burger and Air Fires",
                "Veggie burger on a whole wheat bun, lettuce, tomato and fries",
                true,
                3.99
                );
            
            AddItem(
                "Soup of the day",
                "A cup of the soup of the day, with a side salad",
                false,
                3.69
            );
            
            AddItem(
                "Burrito",
                "A large burrito, with whole pinto beans, salsa and guacamole",
                true,
                4.29
            );
        }
        public IIterator CreateIterator()
        {
            return new CafeMenuIterator(_menuItems);
        }

        public void AddItem(string name, string description, bool isVegeterian, double price)
        {
            var menuItem = new MenuItem(name, description, isVegeterian, price);
            _menuItems.Add(name, menuItem);
        }
    }
}