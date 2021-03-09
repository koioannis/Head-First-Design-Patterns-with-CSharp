#nullable enable
using System;

namespace Chapter_07___The_Adapter_and_Facade_Patterns.The_Facade_Pattern.HomeTheater
{
    public class Projector
    {
        public StreamingPlayer Player { get; set; }
        

        public void On()
        {
            Console.WriteLine("Projector is on");
        }

        public void Off()
        {
            Console.WriteLine("Projector is off");
        }

        public void TvMode()
        {
            throw new NotImplementedException();
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Projector set to widescreen mode");
        }

        public override string? ToString()
        {
            return GetType().Name;
        }

    }
}