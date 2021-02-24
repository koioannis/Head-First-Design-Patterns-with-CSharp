using Chapter_04___The_Factory_Pattern.AbstractFactory.Products.Ingredients;

namespace Chapter_04___The_Factory_Pattern.AbstractFactory.Factory
{
    public class NyPizzaIngredientFactory : IPizzaIngedientFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public IClams CreateClams()
        {
            return new FreshClams();
        }
    }
}