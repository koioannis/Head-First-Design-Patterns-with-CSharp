namespace Chapter_04___The_Factory_Pattern.FactoryMethod.Products
{
    public class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza()
        {
            Name = "NY Style Pepperoni Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Grated Reggiano Cheese");
            Toppings.Add("Sliced Pepperoni");
            Toppings.Add("Garlic");
        }
    }
}