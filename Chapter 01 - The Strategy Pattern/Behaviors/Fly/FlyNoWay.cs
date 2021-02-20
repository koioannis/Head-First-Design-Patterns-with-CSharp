using System;

namespace Chapter_01___The_Strategy_Pattern.Behaviors.Fly
{
  public class FlyNoWay : IFlyBehavior
  {
    public void fly()
    {
      Console.WriteLine("I can't fly");
    }
  }
}