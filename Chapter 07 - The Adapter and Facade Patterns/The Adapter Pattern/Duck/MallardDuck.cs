using System;

namespace Chapter_07___The_Adapter_and_Facade_Patterns.The_Adapter_Pattern.Duck
{
    public class MallardDuck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}