using Chapter_09___The_Iterator_and_Composite_Patterns.The_Iterator_Pattern.Iterators;

namespace Chapter_09___The_Iterator_and_Composite_Patterns.The_Iterator_Pattern.Menus
{
    public interface IMenu
    {
        IIterator CreateIterator();
        void AddItem(string name, string description, bool isVegeterian, double price);
    }
}