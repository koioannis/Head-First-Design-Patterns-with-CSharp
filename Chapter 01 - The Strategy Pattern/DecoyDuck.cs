using System;
using Chapter_01___The_Strategy_Pattern.Behaviors.Fly;
using Chapter_01___The_Strategy_Pattern.Behaviors.Quack;

namespace Chapter_01___The_Strategy_Pattern
{
  public class DecoyDuck : Duck
  {
    public DecoyDuck()
    {
      quackBehavior = new MuteQuack();
      flyBehavior = new FlyNoWay();
    }

    public override void display()
    {
      Console.WriteLine("I'm a decoy duck");
    }
  }
}