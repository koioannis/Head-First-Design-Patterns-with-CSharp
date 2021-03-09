#nullable enable
using System;

namespace Chapter_07___The_Adapter_and_Facade_Patterns.The_Facade_Pattern.HomeTheater
{
    public class Screen
    {
        public void Up()
        {
            Console.WriteLine($"{ToString()} is moving up");
        }

        public void Down()
        {
            Console.WriteLine($"{ToString()} is moving down");
        }

        public override string? ToString()
        {
            return GetType().Name;
        }
    }
}