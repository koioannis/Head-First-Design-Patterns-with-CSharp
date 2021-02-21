using System;
using Chapter_01___The_Strategy_Pattern.Behaviors.Fly;
using Chapter_01___The_Strategy_Pattern.Behaviors.Quack;

namespace Chapter_01___The_Strategy_Pattern
{
  public class MallardDuck : Duck
  {
    public MallardDuck()
    {
      QuackBehavior = new Quack();
      FlyBehavior = new FlyWithWings();
    }

    public override string Display()
    {
      return "I'm a Mallard duck";
    }
  }
}