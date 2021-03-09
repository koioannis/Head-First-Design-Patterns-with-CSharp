#nullable enable
using System;

namespace Chapter_07___The_Adapter_and_Facade_Patterns.The_Facade_Pattern.HomeTheater
{
    public class PopcornPopper
    {
        public void On()
        {
            Console.WriteLine($"{ToString()} is on");
        }

        public void Off()
        {
            Console.WriteLine($"{ToString()} is off");
        }

        public void Pop()
        {
            Console.WriteLine($"{ToString()} Popping pop corn!");
        }

        public override string? ToString()
        {
            return "Popcorn Popper";
        }
    }
}