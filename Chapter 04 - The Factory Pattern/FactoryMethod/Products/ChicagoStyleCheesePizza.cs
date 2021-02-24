namespace Chapter_04___The_Factory_Pattern.FactoryMethod.Products
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago Style Deep Dish Cheese Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";
            
            Toppings.Add("Shredded Mozzarella Cheese");
        }

        public override string Cut()
        {
            return "Cutting the pizza into square slices";
        }
    }
}