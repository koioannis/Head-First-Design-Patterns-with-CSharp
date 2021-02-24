namespace Chapter_04___The_Factory_Pattern.AbstractFactory.Products.Ingredients
{
    public class ReggianoCheese : ICheese
    {
        string ICheese.ToString()
        {
            return "Reggiano Cheese";
        }
    }
}