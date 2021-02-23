namespace Chapter_03___The_Decorator_Pattern.Components
{
    public sealed class EspressoComponent : BeverageComponent
    {
        public EspressoComponent()
        {
            Description = "Espresso";
        }
        

        public override double Cost()
        {
            return 2;
        }
    }
}