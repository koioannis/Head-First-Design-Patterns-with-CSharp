namespace Chapter_04___The_Factory_Pattern.AbstractFactory.Products.Ingredients
{
    public class SlicedPepperoni : IPepperoni
    {
        string IPepperoni.ToString()
        {
            return "Sliced Pepperoni";
        }
    }
}