using Chapter_09___The_Iterator_and_Composite_Patterns.The_Iterator_Pattern;
using Chapter_09___The_Iterator_and_Composite_Patterns.The_Iterator_Pattern.Menus;

namespace Chapter_09___The_Iterator_and_Composite_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            The Iterator Pattern
               */
            var waitress = new Waitress(new DinerMenu(), new PancakeHouseMenu(), new CafeMenu());
            
            waitress.PrintMenu();
          
            
            
            
        }
    }
}