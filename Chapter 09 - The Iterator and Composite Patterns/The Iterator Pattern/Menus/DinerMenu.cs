using System;
using Chapter_09___The_Iterator_and_Composite_Patterns.The_Iterator_Pattern.Iterators;

namespace Chapter_09___The_Iterator_and_Composite_Patterns.The_Iterator_Pattern.Menus
{
    public class DinerMenu : IMenu
    {
        private static readonly int MAX_ITEMS = 6;
        private int _numberOfItems = 0;
        private readonly MenuItem[] _menuItems;

        public DinerMenu()
        {
            _menuItems = new MenuItem[MAX_ITEMS];
            
            AddItem(
                "Vegetarian BLT",
                "(Fakin') Bacon with lettuce & tomato on whole wheat",
                true,
                2.99);
            
            AddItem(
                "BLT",
                "Bacon with lettuce & tomato on whole whear",
                false,
                2.99);
            
            AddItem(
                "Soup of the day",
                "Soup of the day, with a side of potato salad",
                false,
                3.29);
            
            AddItem(
                "Hotdog",
                "A hot dog, with sauerkraut, relish, onions, topped with cheese",
                false,
                3.05);
            
        }

        public IIterator CreateIterator()
        {
            return new DinerMenuIterator(_menuItems);
        }

        public void AddItem(string name, string description, bool vegeterian, double price)
        {
            var menuItem = new MenuItem(name, description, vegeterian, price);
            if (_numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full! Can't add item to menu");
                return;
            }

            _menuItems[_numberOfItems] = menuItem;
            _numberOfItems++;
        }
    }
}