using Chapter_03___The_Decorator_Pattern.Components;

namespace Chapter_03___The_Decorator_Pattern.Decorators
{
    public sealed class SoyDecorator : CondimentDecorator
    {
        private readonly BeverageComponent _beverage;
        
        public SoyDecorator(BeverageComponent beverage)
        {
            _beverage = beverage;
        }

        public override string Description => _beverage.Description + ", Soy";

        public override double Cost()
        {
            return 0.15 + _beverage.Cost();
        }
    }
}