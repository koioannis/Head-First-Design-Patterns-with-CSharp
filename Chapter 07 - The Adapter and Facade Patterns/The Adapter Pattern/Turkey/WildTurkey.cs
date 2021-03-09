using System;

namespace Chapter_07___The_Adapter_and_Facade_Patterns.The_Adapter_Pattern.Turkey
{
    public class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gobble gobble");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying short distance");
        }
    }
}