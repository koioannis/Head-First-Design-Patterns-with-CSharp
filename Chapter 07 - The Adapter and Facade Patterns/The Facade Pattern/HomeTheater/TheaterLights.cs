#nullable enable
using System;

namespace Chapter_07___The_Adapter_and_Facade_Patterns.The_Facade_Pattern.HomeTheater
{
    public class TheaterLights
    {
        public decimal Dim { get; set; }
        
        public void On()
        {
            Console.WriteLine($"{ToString()} are on");
        }

        public void Off()
        {
            Console.WriteLine($"{ToString()} are off");
        }

        public override string? ToString()
        {
            return "Lights";
        }
        
    }
}