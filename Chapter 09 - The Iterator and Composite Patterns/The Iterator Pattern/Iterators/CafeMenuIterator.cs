using System.Collections.Generic;
using System.Linq;

namespace Chapter_09___The_Iterator_and_Composite_Patterns.The_Iterator_Pattern.Iterators
{
    public class CafeMenuIterator : IIterator
    {
        private readonly Dictionary<string, MenuItem> _items;
        private int _position = 0;

        public CafeMenuIterator(Dictionary<string, MenuItem> items)
        {
            _items = items;
        }
        
        public bool HasNext()
        {
            return _position < _items.Count;
        }

        public MenuItem Next()
        {
            var item = _items.ElementAt(_position).Value;
            _position++;

            return item;
        }
    }
}