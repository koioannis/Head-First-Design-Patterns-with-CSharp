using Chapter_04___The_Factory_Pattern.AbstractFactory.Products.Ingredients;

namespace Chapter_04___The_Factory_Pattern.AbstractFactory.Factory
{
    public interface IPizzaIngedientFactory
    {
        public IDough CreateDough();
        
        public ISauce CreateSauce();
        
        public ICheese CreateCheese();
        
        public IPepperoni CreatePepperoni();

        public IClams CreateClams();
    }
}