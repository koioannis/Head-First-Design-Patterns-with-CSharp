using Chapter_07___The_Adapter_and_Facade_Patterns.The_Adapter_Pattern.Duck;
using Chapter_07___The_Adapter_and_Facade_Patterns.The_Adapter_Pattern.Turkey;

namespace Chapter_07___The_Adapter_and_Facade_Patterns.The_Adapter_Pattern.Adapters
{
    public class TurkeyAdapter : IDuck
    {
        private readonly ITurkey _turkey;


        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }
        
        public void Quack()
        {
            _turkey.Gobble();
        }
        
        public void Fly()
        {
            _turkey.Fly();
        }
    }
}