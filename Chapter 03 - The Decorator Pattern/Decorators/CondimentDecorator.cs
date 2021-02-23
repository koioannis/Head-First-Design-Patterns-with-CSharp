using Chapter_03___The_Decorator_Pattern.Components;

namespace Chapter_03___The_Decorator_Pattern.Decorators
{
    public abstract class CondimentDecorator : BeverageComponent
    { 
        public abstract override string Description { get; }
    }
}