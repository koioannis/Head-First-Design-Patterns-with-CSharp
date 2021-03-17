using System;
using Chapter_09___The_Iterator_and_Composite_Patterns.The_Iterator_Pattern.Iterators;
using Chapter_09___The_Iterator_and_Composite_Patterns.The_Iterator_Pattern.Menus;

namespace Chapter_09___The_Iterator_and_Composite_Patterns.The_Iterator_Pattern
{
    public class Waitress
    {
        private readonly IMenu _pancakeHouseMenu;
        private readonly IMenu _dinerMenu;
        private readonly IMenu _cafeMenu;

        public Waitress(IMenu dinerMenu, IMenu pancakeHouseMenu, IMenu cafeMenu)
        {
            _dinerMenu = dinerMenu;
            _pancakeHouseMenu = pancakeHouseMenu;
            _cafeMenu = cafeMenu;
        }

        public void PrintMenu()
        {
            var pancakeIterator = _pancakeHouseMenu.CreateIterator();
            var dinerIterator = _dinerMenu.CreateIterator();
            var cafeIterator = _cafeMenu.CreateIterator();
            
            Console.WriteLine("MENU");
            Console.WriteLine("---");
            Console.WriteLine("BREAKFAST");
            PrintMenu(pancakeIterator);
            
            Console.WriteLine("");
            Console.WriteLine("LUNCH");
            PrintMenu(dinerIterator);
            
            Console.WriteLine("");
            Console.WriteLine("CAFE");
            PrintMenu(cafeIterator);
        }

        private void PrintMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                var item = iterator.Next();
                
                Console.WriteLine($"{item.Name}, {item.Price} -- {item.Description}");
            }
        }
        
    }
}