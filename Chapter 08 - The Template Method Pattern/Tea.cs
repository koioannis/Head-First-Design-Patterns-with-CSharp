using System;

namespace Chapter_08___The_Template_Method_Pattern
{
    public class Tea : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }
        
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }
    }
}