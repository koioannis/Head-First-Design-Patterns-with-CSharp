using System;
using Chapter_01___The_Strategy_Pattern.Behaviors.Fly;
using Chapter_01___The_Strategy_Pattern.Behaviors.Quack;

namespace Chapter_01___The_Strategy_Pattern
{
  public class MallardDuck : Duck
  {
    public MallardDuck()
    {
      quackBehavior = new Quack();
      flyBehavior = new FlyWithWings();
    }

    public override void display()
    {
      Console.WriteLine("I'm a Mallard duck");
    }
  }
}