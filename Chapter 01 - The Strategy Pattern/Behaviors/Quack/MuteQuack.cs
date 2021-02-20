using System;

namespace Chapter_01___The_Strategy_Pattern.Behaviors.Quack
{
  public class MuteQuack : IQuackBehavior
  {
    public void quack()
    {
      Console.WriteLine("Silence..");
    }
  }
}