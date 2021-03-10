using System;

namespace Chapter_08___The_Template_Method_Pattern
{
    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }
        
        public override bool CustomerWantsCondiments()
        {
            var answer = GetUserInput();

            return answer.ToLower().StartsWith("y");
        }

        public string GetUserInput()
        {
            Console.WriteLine("Would you like milk and sugar with your coffee (y/n) ?");

            var answer = Console.ReadLine();

            return answer ?? "no";
        }
        
    }
}