using System.Collections.Generic;
using Chapter_09___The_Iterator_and_Composite_Patterns.The_Iterator_Pattern.Iterators;

namespace Chapter_09___The_Iterator_and_Composite_Patterns.The_Iterator_Pattern.Menus
{
    public class PancakeHouseMenu : IMenu
    {
        private readonly List<MenuItem> _menuItems;

        public PancakeHouseMenu()
        {
            _menuItems = new List<MenuItem>();
            
            AddItem(
                "K&B's Pancake Breakfast", 
                "Pancakes with scrambled eggs and toast",
                true,
                2.99);
            
            AddItem(
                "Regular Pancake Breakfast", 
                "Pancakes with fried eggs, sausage",
                false,
                2.99);
            
            AddItem(
                "Blueberry Pancakes", 
                "Pancakes made with fresh blueberries",
                true,
                3.49);
            
            AddItem(
                "Waffles", 
                "Waffles with your choice of blueberries or strawberries",
                true,
                3.59);
        }

        public IIterator CreateIterator()
        {
            return new PancakeHouseIterator(_menuItems);
        }

        public void AddItem(string name, string description, bool isVegeterian, double price)
        {
            var menuItem = new MenuItem(name, description, isVegeterian, price);
            _menuItems.Add(menuItem);
        }
    }
}