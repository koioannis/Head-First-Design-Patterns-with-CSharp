#nullable enable
using System;

namespace Chapter_07___The_Adapter_and_Facade_Patterns.The_Facade_Pattern.HomeTheater
{
    public class Amplifier
    {
        public Tuner Tuner { get; set; }

        public StreamingPlayer Player { get; set; }

        public int Volume { get; set; }

        public void On()
        {
            Console.WriteLine("Amplifier is on");
        }
        
        public void Off()
        {
            Console.WriteLine("Amplifier is off");
        }

        public void SetStereoSound()
        {
            Console.WriteLine("Sound set to stereo");
        }
        
        public void SetSurroundSound()
        {
            Console.WriteLine("Sound set to surround");
        }

        public override string? ToString()
        {
            return GetType().FullName;
        }
    }
}