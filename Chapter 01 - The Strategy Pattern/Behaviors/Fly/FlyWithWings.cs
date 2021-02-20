using System;

namespace Chapter_01___The_Strategy_Pattern.Behaviors.Fly
{
  public class FlyWithWings : IFlyBehavior
  {
    public void fly()
    {
      Console.WriteLine("I'm flying!");
    }
  }
}