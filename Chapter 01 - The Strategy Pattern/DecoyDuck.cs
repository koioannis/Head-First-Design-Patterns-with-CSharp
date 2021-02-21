using System;
using Chapter_01___The_Strategy_Pattern.Behaviors.Fly;
using Chapter_01___The_Strategy_Pattern.Behaviors.Quack;

namespace Chapter_01___The_Strategy_Pattern
{
  public class DecoyDuck : Duck
  {
    public DecoyDuck()
    {
      QuackBehavior = new MuteQuack();
      FlyBehavior = new FlyNoWay();
    }

    public override string Display()
    {
      return "I'm a decoy duck";
    }
  }
}