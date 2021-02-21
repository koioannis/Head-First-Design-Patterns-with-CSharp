using System;

namespace Chapter_01___The_Strategy_Pattern.Behaviors.Fly
{
  public class FlyRocketPowered : IFlyBehavior
  {
    public string Fly()
    {
      return "I'm flying with a rocket!";
    }
  }
}