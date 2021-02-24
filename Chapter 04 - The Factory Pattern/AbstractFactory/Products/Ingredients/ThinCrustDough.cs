namespace Chapter_04___The_Factory_Pattern.AbstractFactory.Products.Ingredients
{
    public class ThinCrustDough : IDough
    {
        string IDough.ToString()
        {
            return "Thin Crust Dough";
        }
    }
}