using System.Collections.Generic;

namespace Chapter_09___The_Iterator_and_Composite_Patterns.The_Iterator_Pattern.Iterators
{
    public class PancakeHouseIterator : IIterator
    {
        private readonly List<MenuItem> _items;
        private int _position = 0;

        public PancakeHouseIterator(List<MenuItem> items)
        {
            _items = items;
        }

        public bool HasNext()
        {
            return _position < _items.Count && _items[_position] != null;
        }

        public MenuItem Next()
        {
            var item = _items[_position];
            _position++;

            return item;
        }
    }
}