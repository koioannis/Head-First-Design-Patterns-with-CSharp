namespace Chapter_09___The_Iterator_and_Composite_Patterns.The_Iterator_Pattern.Iterators
{
    public class DinerMenuIterator : IIterator
    {
        private readonly MenuItem[] _items;
        private int _position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            _items = items;
        }
        
        public bool HasNext()
        {
            return _position < _items.Length && _items[_position] != null;
        }

        public MenuItem Next()
        {
            var item = _items[_position];
            _position++;
            return item;
        }
    }
}