namespace Chapter_04___The_Factory_Pattern.FactoryMethod.Products
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            
            Toppings.Add("Grated Reggiano Cheese");
        }
        
    }
}