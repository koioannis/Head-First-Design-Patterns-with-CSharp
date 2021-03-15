namespace Chapter_09___The_Iterator_and_Composite_Patterns.The_Iterator_Pattern.Iterators
{
    public interface IIterator
    {
        bool HasNext();
        MenuItem Next();
    }
}