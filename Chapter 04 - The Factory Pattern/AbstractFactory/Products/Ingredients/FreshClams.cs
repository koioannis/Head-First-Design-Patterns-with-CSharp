namespace Chapter_04___The_Factory_Pattern.AbstractFactory.Products.Ingredients
{
    public class FreshClams : IClams
    {
        string IClams.ToString()
        {
            return "Fresh clams";
        }
    }
}