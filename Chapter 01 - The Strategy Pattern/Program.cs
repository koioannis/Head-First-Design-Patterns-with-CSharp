using System;
using Chapter_01___The_Strategy_Pattern.Behaviors.Fly;

namespace Chapter_01___The_Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();
            
            mallard.flyBehavior = new FlyRocketPowered();
            mallard.performFly();
        }
    }
}

