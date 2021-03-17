using System;

namespace Chapter_09___The_Iterator_and_Composite_Patterns.The_Composite_Pattern
{
    public class MenuComponent
    {
        public virtual string Name => throw new NotSupportedException();
        public virtual string Description => throw new NotSupportedException();
        public virtual double Price => throw new NotSupportedException();
        public virtual bool IsVegetarian => throw new NotSupportedException();

        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }
        
        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }
        
        public virtual MenuComponent GetChild(int index)
        {
            throw new NotSupportedException();
        }

        public virtual void Print()
        {
            throw new NotSupportedException();
        }
    }
}
