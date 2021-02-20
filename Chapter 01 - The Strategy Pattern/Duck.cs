using System;
using Chapter_01___The_Strategy_Pattern.Behaviors.Fly;
using Chapter_01___The_Strategy_Pattern.Behaviors.Quack;

namespace Chapter_01___The_Strategy_Pattern
{
  public abstract class Duck
  {
    public IFlyBehavior flyBehavior { get; set; }
    public IQuackBehavior quackBehavior { get; set;}

    public Duck()
    {
        
    }

    public void performFly()
    {
      flyBehavior.fly();
    }

    public void performQuack()
    {
      quackBehavior.quack();
    }

    public void swim()
    {
      Console.WriteLine("All ducks float, even decoys!");
    }

    public abstract void display();
  }
}