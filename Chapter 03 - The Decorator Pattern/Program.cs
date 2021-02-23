using System;
using Chapter_03___The_Decorator_Pattern.Components;
using Chapter_03___The_Decorator_Pattern.Decorators;

namespace Chapter_03___The_Decorator_Pattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BeverageComponent beverage = new EspressoComponent();
            Console.WriteLine($"{beverage.Description}: {beverage.Cost()}");
            
            BeverageComponent beverage2 = new EspressoComponent();
            beverage2 = new MochaDecorator(beverage2);
            beverage2 = new MochaDecorator(beverage2);
            beverage2 = new WhipDecorator(beverage2);

            Console.WriteLine($"{beverage2.Description}: {beverage2.Cost()}");
        }
    }
}