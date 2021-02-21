using System;

namespace Chapter_01___The_Strategy_Pattern.Behaviors.Quack
{
  public class Quack : IQuackBehavior
  {
    public string Quacking()
    {
      return "Quack!!!";
    }
  }
}