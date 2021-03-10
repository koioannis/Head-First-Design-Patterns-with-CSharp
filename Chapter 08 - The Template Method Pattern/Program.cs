using System;

namespace Chapter_08___The_Template_Method_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var tea = new Tea();
            tea.PrepareRecipe();
            Console.WriteLine("---------------");
            var coffee = new Coffee();
            coffee.PrepareRecipe();
        }
    }
}