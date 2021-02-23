using Chapter_03___The_Decorator_Pattern.Components;

namespace Chapter_03___The_Decorator_Pattern.Decorators
{
    public class MochaDecorator : CondimentDecorator
    {
        private readonly BeverageComponent _beverage;
        
        public MochaDecorator(BeverageComponent beverage)
        {
            _beverage = beverage;
        }

        public override string Description => _beverage.Description + ", Mocha";

        public override double Cost()
        {
            return 0.20 + _beverage.Cost();
        }
    }
}