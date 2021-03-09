using Chapter_07___The_Adapter_and_Facade_Patterns.The_Adapter_Pattern.Duck;
using Chapter_07___The_Adapter_and_Facade_Patterns.The_Adapter_Pattern.Turkey;

namespace Chapter_07___The_Adapter_and_Facade_Patterns.The_Adapter_Pattern.Adapters
{
    public class DuckAdapter : ITurkey
    {
        private readonly IDuck _duck;

        public DuckAdapter(IDuck duck)
        {
            _duck = duck;
        }
        
        public void Gobble()
        {
            _duck.Quack();
        }

        public void Fly()
        {
            _duck.Fly();
        }
    }
}