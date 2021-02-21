using System;

namespace Chapter_01___The_Strategy_Pattern.Behaviors.Fly
{
  public class FlyWithWings : IFlyBehavior
  {
    public string Fly()
    {
      return "I'm flying!";
    }
  }
}