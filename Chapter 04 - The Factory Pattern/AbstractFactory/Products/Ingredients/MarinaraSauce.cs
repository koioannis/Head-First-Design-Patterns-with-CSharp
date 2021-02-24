namespace Chapter_04___The_Factory_Pattern.AbstractFactory.Products.Ingredients
{
    public class MarinaraSauce : ISauce
    {
        string ISauce.ToString()
        {
            return "Marinara Sauce";
        }
    }
}