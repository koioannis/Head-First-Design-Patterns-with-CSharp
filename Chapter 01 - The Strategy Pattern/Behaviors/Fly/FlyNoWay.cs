using System;

namespace Chapter_01___The_Strategy_Pattern.Behaviors.Fly
{
  public class FlyNoWay : IFlyBehavior
  {
    public string Fly()
    {
      return "I can't fly";
    }
  }
}