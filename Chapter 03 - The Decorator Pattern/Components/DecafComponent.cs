namespace Chapter_03___The_Decorator_Pattern.Components
{
    public sealed class DecafComponent : BeverageComponent
    {
        public DecafComponent()
        {
            Description = "Decaf";
        }
        

        public override double Cost()
        {
            return 1.00;
        }
    }
}