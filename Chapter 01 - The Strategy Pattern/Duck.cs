using System;
using Chapter_01___The_Strategy_Pattern.Behaviors.Fly;
using Chapter_01___The_Strategy_Pattern.Behaviors.Quack;

namespace Chapter_01___The_Strategy_Pattern
{
  public abstract class Duck
  {
    public IFlyBehavior FlyBehavior { get; set; }
    public IQuackBehavior QuackBehavior { get; set; }

    public Duck()
    {
        
    }

    public string PerformFly()
    {
      return FlyBehavior.Fly();
    }

    public string PerformQuack()
    {
      return QuackBehavior.Quacking();
    }

    public string Swim()
    {
      return "All ducks float, even decoys!";
    }

    public abstract string Display();
  }
}