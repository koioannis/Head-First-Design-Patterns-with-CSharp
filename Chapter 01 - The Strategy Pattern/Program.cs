using System;
using Chapter_01___The_Strategy_Pattern.Behaviors.Fly;

namespace Chapter_01___The_Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            Console.WriteLine(mallard.PerformQuack());
            Console.WriteLine(mallard.PerformFly());
            
            mallard.FlyBehavior = new FlyRocketPowered();
            Console.WriteLine(mallard.PerformFly());
        }
    }
}

