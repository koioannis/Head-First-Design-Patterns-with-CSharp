using Chapter_09___The_Iterator_and_Composite_Patterns.The_Composite_Pattern;

namespace Chapter_09___The_Iterator_and_Composite_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            The Iterator Pattern
            
            var waitress = new Waitress(new DinerMenu(), new PancakeHouseMenu(), new CafeMenu());
            
            waitress.PrintMenu();
             */

            /* The composite pattern
             
             */
            var pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "breakfast");
            var dinerMenu = new Menu("DINER MENU", "Lunch");
            var cafeMenu = new Menu("CAFE MENU", "Dinner");
            var dessertMenu = new Menu("DESSERT MENU", "Dessert");

            var allMenus = new Menu("ALL MENUS", "All menus combined");
            
            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);
            
            pancakeHouseMenu.Add(new MenuItem(
                "K&B's Pancake Breakfast", 
                "Pancakes with scrambled eggs and toast",
                true,
                2.99));
            
            cafeMenu.Add(new MenuItem(
                "Veggie Burger and Air Fires",
                "Veggie burger on a whole wheat bun, lettuce, tomato and fries",
                true,
                3.99
                ));
            
            dinerMenu.Add(new MenuItem(
                "Pasta",
                "Spagheti with Marinara Sauce, and a slice of sourdough bread",
                true,
                3.89
                ));
            
            dinerMenu.Add(dessertMenu);

            dessertMenu.Add(new MenuItem(
                "Apple Pie",
                "Apple pie with flakey crust, topped with vanilla ice cream",
                true,
                1.59));

            var waitress = new WaitressComposite(allMenus);
            waitress.PrintMenu();
        }
    }
}