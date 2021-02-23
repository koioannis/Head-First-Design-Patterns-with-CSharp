namespace Chapter_03___The_Decorator_Pattern.Components
{
    public abstract class BeverageComponent
    {
        public virtual string Description { get; protected set; }

        public abstract double Cost();
    }
}