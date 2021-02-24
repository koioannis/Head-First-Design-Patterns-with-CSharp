namespace Chapter_04___The_Factory_Pattern.FactoryMethod.Products
{
    public class NYStyleClamPizza : Pizza
    {
        public NYStyleClamPizza()
        {
            Name = "NY Style Clam Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            
            Toppings.Add("Grated Reggiano Cheece");
            Toppings.Add("Fresh Clams");
        }
        
    }
}