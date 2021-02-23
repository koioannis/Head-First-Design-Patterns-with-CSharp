using Chapter_03___The_Decorator_Pattern.Components;

namespace Chapter_03___The_Decorator_Pattern.Decorators
{
    public sealed class WhipDecorator : CondimentDecorator
    {
        private readonly BeverageComponent _beverage;
        
        public WhipDecorator(BeverageComponent beverage)
        {
            _beverage = beverage;
        }

        public override string Description => _beverage.Description + ", Whip";

        public override double Cost()
        {
            return 0.10 + _beverage.Cost();
        }
    }
}