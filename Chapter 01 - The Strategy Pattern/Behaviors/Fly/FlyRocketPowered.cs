using System;

namespace Chapter_01___The_Strategy_Pattern.Behaviors.Fly
{
  public class FlyRocketPowered : IFlyBehavior
  {
    public void fly()
    {
      Console.WriteLine("I'm flying with a rocket!");
    }
  }
}